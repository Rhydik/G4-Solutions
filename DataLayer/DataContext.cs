namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext2")
        {
        }

        public virtual DbSet<AntalTimmar> AntalTimmar { get; set; }
        public virtual DbSet<Avdelning> Avdelning { get; set; }
        public virtual DbSet<Direktkostnad> Direktkostnad { get; set; }
        public virtual DbSet<Intäktsbudget> Intäktsbudget { get; set; }
        public virtual DbSet<Konto> Konto { get; set; }
        public virtual DbSet<KundKategori> KundKategori { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Produktgrupp> Produktgrupp { get; set; }
        public virtual DbSet<Produktkategori> Produktkategori { get; set; }
        public virtual DbSet<Prognos> Prognos { get; set; }
        public virtual DbSet<schablonkostnad> schablonkostnad { get; set; }
        public virtual DbSet<Aktivitet> Aktivitet { get; set; }
        public virtual DbSet<Kund> Kund { get; set; }
        public virtual DbSet<PersonalProdukt> PersonalProdukt { get; set; }
        public virtual DbSet<Produkt> Produkt { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avdelning>()
                .HasMany(e => e.Aktivitet)
                .WithRequired(e => e.Avdelning)
                .HasForeignKey(e => e.Avdelning_AvdelningID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Avdelning>()
                .HasMany(e => e.Produkt)
                .WithRequired(e => e.Avdelning)
                .HasForeignKey(e => e.Avdelning_AvdelningID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Avdelning>()
                .HasMany(e => e.Personal)
                .WithMany(e => e.Avdelning)
                .Map(m => m.ToTable("AvdelningPersonal"));

            modelBuilder.Entity<Avdelning>()
                .HasMany(e => e.Konto)
                .WithMany(e => e.Avdelning)
                .Map(m => m.ToTable("KontoAvdelning"));

            modelBuilder.Entity<Direktkostnad>()
                .Property(e => e.Belopp)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Intäktsbudget>()
                .Property(e => e.Avtal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Intäktsbudget>()
                .Property(e => e.Tillägg)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Intäktsbudget>()
                .Property(e => e.Budget)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Intäktsbudget>()
                .HasMany(e => e.Produkt)
                .WithOptional(e => e.Intäktsbudget)
                .HasForeignKey(e => e.Intäktsbudget_IntäktsbudgetID);

            modelBuilder.Entity<Intäktsbudget>()
                .HasMany(e => e.Prognos)
                .WithRequired(e => e.Intäktsbudget)
                .HasForeignKey(e => e.Intäktsbudget_IntäktsbudgetID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Konto>()
                .HasMany(e => e.Direktkostnad)
                .WithRequired(e => e.Konto)
                .HasForeignKey(e => e.Konto_KontoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Konto>()
                .HasMany(e => e.schablonkostnad)
                .WithRequired(e => e.Konto)
                .HasForeignKey(e => e.Konto_KontoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KundKategori>()
                .HasMany(e => e.Kund)
                .WithRequired(e => e.KundKategori)
                .HasForeignKey(e => e.KundKategori_KundKategoriID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Personal>()
                .HasMany(e => e.AntalTimmar)
                .WithRequired(e => e.Personal)
                .HasForeignKey(e => e.Personal_PersonalID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Personal>()
                .HasMany(e => e.PersonalProdukt)
                .WithRequired(e => e.Personal)
                .HasForeignKey(e => e.Personal_PersonalID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produktgrupp>()
                .HasMany(e => e.Produkt)
                .WithRequired(e => e.Produktgrupp)
                .HasForeignKey(e => e.Produktgrupp_ProduktgruppID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produktkategori>()
                .HasMany(e => e.Produkt)
                .WithRequired(e => e.Produktkategori)
                .HasForeignKey(e => e.Produktkategori_ProduktkategoriID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prognos>()
                .Property(e => e.Belopp)
                .HasPrecision(18, 0);

            modelBuilder.Entity<schablonkostnad>()
                .Property(e => e.Belopp)
                .HasPrecision(18, 0);
        }
    }
}
