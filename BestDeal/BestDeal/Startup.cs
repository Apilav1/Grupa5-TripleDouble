using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BestDeal.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BestDeal.Models;
using Microsoft.Extensions.Options;
using BestDeal.AdapteriPodataka;
using BestDeal.Interfaces;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace BestDeal
{
    public class Startup
    {
        private void CreateRoles(IServiceProvider serviceProvider)
        {
           // System.Diagnostics.Debug.WriteLine("Dosao sam do 0");
            //initializing custom roles 
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            string email = "admin@bestdeal.ba";
            Task<IdentityResult> roleResult;
            Task<bool> daLiJeAdmin = RoleManager.RoleExistsAsync("Admin");
            daLiJeAdmin.Wait();
           // System.Diagnostics.Debug.WriteLine("Dosao sam do 1");
            if (!daLiJeAdmin.Result)
            {
                roleResult = RoleManager.CreateAsync(new IdentityRole("Admin"));
                roleResult.Wait();
                System.Diagnostics.Debug.WriteLine("Dosao sam do 2");
            }

            // trazimo ko je admin
            Task<IdentityUser> testAdmin = UserManager.FindByEmailAsync(email);
            testAdmin.Wait();
            System.Diagnostics.Debug.WriteLine("Dosao sam do 3");
            if (testAdmin.Result == null)
            {
                IdentityUser admin = new IdentityUser();
                admin.Email = email;
                admin.UserName = email;
                Task<IdentityResult> korisnik = UserManager.CreateAsync(admin, "Sifra1.");
                korisnik.Wait();
                System.Diagnostics.Debug.WriteLine("Dosao sam do 4");
                if (korisnik.Result.Succeeded)
                {
                    Task<IdentityResult> rola = UserManager.AddToRoleAsync(admin, "Admin");
                    rola.Wait();
                    System.Diagnostics.Debug.WriteLine("Dosao sam do 5");
                }
            }
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<BestDealContext>(options =>
       options.UseSqlServer(Configuration.GetConnectionString("AzureConnection")));
            services.AddIdentity<IdentityUser, IdentityRole>() //prostor za custom usera
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<BestDealContext>()
                .AddDefaultTokenProviders();
            services.AddTransient<IArtikli, ArtikalKreator>();
            services.AddTransient<ITipovi, TipKreator>();
            services.AddTransient<INarudzba, NarudzbaKreator>();
            services.AddTransient<IRecenzije, RecenzijaKreator>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => Korpa.DajKorpu(sp));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMemoryCache();
            services.AddSession();
            services.AddAuthentication().AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
                googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "filterKategorija",
                    template: "ArtikliApp/{action}/{category?}",
                    defaults: new { Controller = "ArtikliApp", action = "List" });
            });
            // CreateRoles(serviceProvider);
        }

    }
}
