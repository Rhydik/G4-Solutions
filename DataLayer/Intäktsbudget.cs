namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Intäktsbudget
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Intäktsbudget()
        {
            Produkt = new HashSet<Produkt>();
            Prognos = new HashSet<Prognos>();
        }

        public int IntäktsbudgetID { get; set; }

        public bool Låst { get; set; }

        public decimal Avtal { get; set; }

        public bool GradA { get; set; }

        public decimal Tillägg { get; set; }

        public bool GradT { get; set; }

        public decimal Budget { get; set; }

        public int Tim { get; set; }

        [Required]
        public string Kommentar { get; set; }

        [Required]
        public string Kund_KundID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produkt> Produkt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prognos> Prognos { get; set; }
    }
}
