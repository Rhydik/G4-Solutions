namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KostnadsbudgetSet")]
    public partial class KostnadsbudgetSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KostnadsbudgetSet()
        {
            AktivitetKostnadsbudget = new HashSet<AktivitetKostnadsbudget>();
            KostnadsbudgetProdukt = new HashSet<KostnadsbudgetProdukt>();
            Direktkostnad = new HashSet<Direktkostnad>();
            Personal = new HashSet<Personal>();
        }

        [Key]
        public int KostnadsbudgetID { get; set; }

        public decimal Summering { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AktivitetKostnadsbudget> AktivitetKostnadsbudget { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KostnadsbudgetProdukt> KostnadsbudgetProdukt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Direktkostnad> Direktkostnad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personal> Personal { get; set; }
    }
}
