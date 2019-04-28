namespace AracKiralama.DAL.EntityFramework
{
    using AracKiralama.Entities;
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;


    public partial class AracKiralamaSoaContext : DbContext
    {
        public AracKiralamaSoaContext()
            : base("name=AracKiralamaSoaContext")
        {
        }

        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<KiralikArac> Kiralik { get; set; }
        public virtual DbSet<Kullanicilar> Kullanici { get; set; }
        public virtual DbSet<Rezervasyon> Rezervasyon { get; set; }
        public virtual DbSet<Roller> Rol { get; set; }
        public virtual DbSet<SirketBilgi> Sirket { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arac>()
                .Property(e => e.gunlukKiralikFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KiralikArac>()
                .Property(e => e.alinanUcret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Kullanicilar>()
                .HasMany(e => e.Rez)
                .WithOptional(e => e.kullanici)
                .HasForeignKey(e => e.aracID);
        }
    }
}
