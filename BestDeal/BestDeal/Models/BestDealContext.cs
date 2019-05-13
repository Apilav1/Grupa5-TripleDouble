using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    //TODO: Skontati koji context ide, identitymodel, No authorization problem
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }
    //IdentityDbContext<ApplicationUser> ???
    public class BestDealContext : DbContext
    {

        //automatske migracije
        private static readonly bool[] _migrated = { false };

        public BestDealContext(DbContextOptions<BestDealContext> options) : base(options)
        {
          /*  if (!_migrated[0])
                lock (_migrated)
                    if (!_migrated[0])
                    {
                        Database.Migrate(); // apply all migrations
                        _migrated[0] = true;
                    }*/
        }
        public DbSet<Korisnik> Korisnik { get; set; }
        //TODO: Dodati preostale klase kad se završi model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>().ToTable("korisnici");
            //TODO: Dodati preostale klase kad se završi model
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=EFMiscellanous.ConnectionResiliency;Trusted_Connection=True;ConnectRetryCount=0",
                    options => options.EnableRetryOnFailure());
        }
    }
}
