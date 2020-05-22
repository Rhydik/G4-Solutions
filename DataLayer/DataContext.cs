namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DatabaseModel")
        {
        }

        public virtual DbSet<AntalTimmar> AntalTimmar { get; set; }
        public virtual DbSet<Avdelning> Avdelning { get; set; }
        public virtual DbSet<AvdelningPersonalxRef> AvdelningPersonalxRef { get; set; }
        public virtual DbSet<DirektkostnadProdukt> DirektkostnadProdukt { get; set; }
        public virtual DbSet<Intäktsbudget> Intäktsbudget { get; set; }
        public virtual DbSet<Konto> Konto { get; set; }
        public virtual DbSet<KostnadsbudgetSet> KostnadsbudgetSet { get; set; }
        public virtual DbSet<KundKategori> KundKategori { get; set; }
        public virtual DbSet<Lås> Lås { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Produktgrupp> Produktgrupp { get; set; }
        public virtual DbSet<Produktkategori> Produktkategori { get; set; }
        public virtual DbSet<Prognos> Prognos { get; set; }
        public virtual DbSet<schablonkostnad> schablonkostnad { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Aktivitet> Aktivitet { get; set; }
        public virtual DbSet<AktivitetKostnadsbudget> AktivitetKostnadsbudget { get; set; }
        public virtual DbSet<KostnadsbudgetProdukt> KostnadsbudgetProdukt { get; set; }
        public virtual DbSet<Kund> Kund { get; set; }
        public virtual DbSet<KundIntäktsbudget> KundIntäktsbudget { get; set; }
        public virtual DbSet<PersonalProdukt> PersonalProdukt { get; set; }
        public virtual DbSet<Produkt> Produkt { get; set; }
        public virtual DbSet<ProduktIntäktsbudget> ProduktIntäktsbudget { get; set; }
        public virtual DbSet<PersonalAktivitet> PersonalAktivitet { get; set; }
        public virtual DbSet<DirektkostnadAktivitet> DirektkostnadAktivitet { get; set; }

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
                .HasMany(e => e.Konto)
                .WithMany(e => e.Avdelning)
                .Map(m => m.ToTable("KontoAvdelning"));


            modelBuilder.Entity<Intäktsbudget>()
                .Property(e => e.Avtal);

            modelBuilder.Entity<Intäktsbudget>()
                .Property(e => e.Tillägg);

            modelBuilder.Entity<Intäktsbudget>()
                .Property(e => e.Budget);

            modelBuilder.Entity<Intäktsbudget>()
                .HasMany(e => e.KundIntäktsbudget)
                .WithRequired(e => e.Intäktsbudget)
                .HasForeignKey(e => e.Intäktsbudget_IntäktsbudgetID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Intäktsbudget>()
                .HasMany(e => e.ProduktIntäktsbudget)
                .WithRequired(e => e.Intäktsbudget)
                .HasForeignKey(e => e.Intäktsbudget_IntäktsbudgetID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Intäktsbudget>()
                .HasMany(e => e.Prognos)
                .WithRequired(e => e.Intäktsbudget)
                .HasForeignKey(e => e.Intäktsbudget_IntäktsbudgetID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Konto>()
                .HasMany(e => e.DirektkostnadProdukt)
                .WithRequired(e => e.Konto)
                .HasForeignKey(e => e.Konto_KontoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Konto>()
                .HasMany(e => e.schablonkostnad)
                .WithRequired(e => e.Konto)
                .HasForeignKey(e => e.Konto_KontoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KostnadsbudgetSet>()
                .Property(e => e.Summering);

            modelBuilder.Entity<KostnadsbudgetSet>()
                .HasMany(e => e.AktivitetKostnadsbudget)
                .WithRequired(e => e.KostnadsbudgetSet)
                .HasForeignKey(e => e.Kostnadsbudget_KostnadsbudgetID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KostnadsbudgetSet>()
                .HasMany(e => e.KostnadsbudgetProdukt)
                .WithRequired(e => e.KostnadsbudgetSet)
                .HasForeignKey(e => e.Kostnadsbudget_KostnadsbudgetID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KostnadsbudgetSet>()
                .HasMany(e => e.Personal)
                .WithMany(e => e.KostnadsbudgetSet)
                .Map(m => m.ToTable("PersonalKostnadsbudget").MapLeftKey("Kostnadsbudget_KostnadsbudgetID"));

            modelBuilder.Entity<KundKategori>()
                .HasMany(e => e.Kund)
                .WithRequired(e => e.KundKategori)
                .HasForeignKey(e => e.KundKategori_KundKategoriID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Sysselsättningsgrad);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Vakansavdrag);

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
                .Property(e => e.Belopp);

            modelBuilder.Entity<schablonkostnad>()
                .Property(e => e.Belopp);
        }
    }
}
