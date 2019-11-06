namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Direktkostnad")]
    public partial class Direktkostnad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Direktkostnad()
        {
            KostnadsbudgetSet = new HashSet<KostnadsbudgetSet>();
        }

        public int DirektkostnadID { get; set; }

        [Required]
        public string Namn { get; set; }

        public decimal Belopp { get; set; }

        public int Konto_KontoID { get; set; }

        public virtual Konto Konto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KostnadsbudgetSet> KostnadsbudgetSet { get; set; }
    }
}
