namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kund")]
    public partial class Kund
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kund()
        {
            Intäktsbudget = new HashSet<Intäktsbudget>();
        }

        public int KundID { get; set; }

        [Required]
        public string Namn { get; set; }

        public int KundKategori_KundKategoriID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Intäktsbudget> Intäktsbudget { get; set; }

        public virtual KundKategori KundKategori { get; set; }
    }
}
