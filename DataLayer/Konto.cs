namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Konto")]
    public partial class Konto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Konto()
        {
            DirektkostnadProdukt = new HashSet<DirektkostnadProdukt>();
            schablonkostnad = new HashSet<schablonkostnad>();
            Avdelning = new HashSet<Avdelning>();
            DirektkostnadAktivitet = new HashSet<DirektkostnadAktivitet>();
        }

        public int KontoID { get; set; }

        [Required]
        public string Benämning { get; set; }

        [Column("konto")]
        [Required]
        public int konto1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DirektkostnadProdukt> DirektkostnadProdukt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<schablonkostnad> schablonkostnad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avdelning> Avdelning { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DirektkostnadAktivitet> DirektkostnadAktivitet { get; set; }

    }
}
