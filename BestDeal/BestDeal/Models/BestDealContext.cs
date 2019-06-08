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
    // You can add profile data for the user by adding more properties to your IdentityUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

    //IdentityDbContext<IdentityUser> ???
    public class BestDealContext : IdentityDbContext<IdentityUser>
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
        public DbSet<IdentityUser> IdentityUser { get; set; }

        public DbSet<KorpaInfo> KorpaInfo { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<Obavijest> Obavijest { get; set; }
        public DbSet<ChatObavijest> ChatObavijest { get; set; }
        public DbSet<NarudzbeObavijest> NarudzbeObavijest { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
       // public DbSet<StanjeNarudzbe> StanjeNarudzbe { get; set; }
        public DbSet<Tip> Tip { get; set; }
      //  public DbSet<Tipovi> Tipovi { get; set; }
        public DbSet<Artikal> Artikal { get; set; }
       public DbSet<Korpa> Korpa { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser>().ToTable("IdentityUsers");
            modelBuilder.Entity<Korpa>().ToTable("Korpa");
            modelBuilder.Entity<KorpaInfo>().ToTable("KorpaInfo");
            modelBuilder.Entity<Narudzba>().ToTable("Narudzba");
            modelBuilder.Entity<Obavijest>().ToTable("Obavijest");
            modelBuilder.Entity<ChatObavijest>().ToTable("ChatObavijest");
            modelBuilder.Entity<NarudzbeObavijest>().ToTable("NarudzbeObavijest");
            modelBuilder.Entity<Recenzija>().ToTable("Recenzija");
            modelBuilder.Ignore<StanjeNarudzbe>();
            modelBuilder.Entity<Tip>().ToTable("Tip");
            modelBuilder.Ignore<Tipovi>();
            modelBuilder.Entity<Artikal>().ToTable("Artikal");
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
