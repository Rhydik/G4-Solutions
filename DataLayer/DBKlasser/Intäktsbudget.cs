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
            KundIntäktsbudget = new HashSet<KundIntäktsbudget>();
            ProduktIntäktsbudget = new HashSet<ProduktIntäktsbudget>();
            Prognos = new HashSet<Prognos>();
        }

        public int IntäktsbudgetID { get; set; }

        public bool Låst { get; set; }

        public double Avtal { get; set; }

        public bool GradA { get; set; }

        public double Tillägg { get; set; }

        public bool GradT { get; set; }

        public double Budget { get; set; }

        public int Tim { get; set; }

        [Required]
        public string Kommentar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KundIntäktsbudget> KundIntäktsbudget { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProduktIntäktsbudget> ProduktIntäktsbudget { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prognos> Prognos { get; set; }
    }
}
