namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produkt")]
    public partial class Produkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produkt()
        {
            Personal = new HashSet<Personal>();
        }

        public int ProduktID { get; set; }

        [Required]
        public string ProduktKod { get; set; }

        [Required]
        public string Namn { get; set; }

        public int Intäktsbudget_IntäktsbudgetID { get; set; }

        public int Prognos_PrognosID { get; set; }

        public int Produktkategori_ProduktkategoriID { get; set; }

        public int Produktgrupp_ProduktgruppID { get; set; }

        public virtual Intäktsbudget Intäktsbudget { get; set; }

        public virtual Produktgrupp Produktgrupp { get; set; }

        public virtual Produktkategori Produktkategori { get; set; }

        public virtual Prognos Prognos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personal> Personal { get; set; }
    }
}
