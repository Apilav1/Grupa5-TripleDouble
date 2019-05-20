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

    //IdentityDbContext<ApplicationUser> ???
    public class BestDealContext : IdentityDbContext<ApplicationUser>
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
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        //TODO: Dodati preostale klase kad se završi model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUsers");
            //TODO: Dodati preostale klase kad se završi model
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
