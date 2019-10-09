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

        public int Prognos_PrognosID { get; set; }

        public int Kund_KundID { get; set; }

        public virtual Kund Kund { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produkt> Produkt { get; set; }

        public virtual Prognos Prognos { get; set; }
    }
}
