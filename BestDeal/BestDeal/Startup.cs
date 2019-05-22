using System;
using System.Threading.Tasks;
using BestDeal.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace BestDeal
{
    public class Startup
    {
        private void CreateRoles(IServiceProvider serviceProvider)
        {
            //initializing custom roles 
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            string email = "test@test.ba";
            Task<IdentityResult> roleResult;
            Task<bool> daLiJeAdmin = RoleManager.RoleExistsAsync("Admin");
            daLiJeAdmin.Wait();
            if (!daLiJeAdmin.Result)
            {
                roleResult = RoleManager.CreateAsync(new IdentityRole("Admin"));
                roleResult.Wait();
            }
          
            // trazimo ko je admin
            Task<ApplicationUser> testAdmin = UserManager.FindByEmailAsync(email);
            testAdmin.Wait();
            if (testAdmin.Result == null)
            {
                ApplicationUser admin = new ApplicationUser();
                admin.Email = email;
                admin.UserName = email;
                Task<IdentityResult> korisnik = UserManager.CreateAsync(admin, "Sifra1.");
                korisnik.Wait();
                if (korisnik.Result.Succeeded)
                {
                    Task<IdentityResult> rola = UserManager.AddToRoleAsync(admin, "Admin");
                    rola.Wait();
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
            services.AddDbContext<BestDealContext>(options =>
       options.UseSqlServer(Configuration.GetConnectionString("AzureConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
            })
     .AddEntityFrameworkStores<BestDealContext>()
     .AddRoles<IdentityRole>()
     .AddSignInManager<SignInManager<ApplicationUser>>()
     .AddDefaultUI();
            //.AddDefaultTokenProviders(); //Ovo je za 2FA
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
     .AddRazorPagesOptions(options =>
     {
         options.AllowAreas = true;
         options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
         options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
     });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });

            services.AddSingleton<IEmailSender, EmailSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            //  SeedData.Initialize(app.ApplicationServices);
            //AsyncContext.Run(async () => { await CreateRoles(serviceProvider); });
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
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
           // CreateRoles(serviceProvider); //TODO: Ispitati gdje je ovdje problem
        }
    }
}
