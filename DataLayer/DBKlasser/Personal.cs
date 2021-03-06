namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personal")]
    public partial class Personal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personal()
        {
            AntalTimmar = new HashSet<AntalTimmar>();
            PersonalProdukt = new HashSet<PersonalProdukt>();
            PersonalAktivitet = new HashSet<PersonalAktivitet>();
            AvdelningPersonalxRef = new HashSet<AvdelningPersonalxRef>();
            KostnadsbudgetSet = new HashSet<KostnadsbudgetSet>();
        }

        public int PersonalID { get; set; }

        [Required]
        public string PersonNr { get; set; }

        [Required]
        public string Namn { get; set; }

        public int Månadslön { get; set; }

        public double Sysselsättningsgrad { get; set; }

        public double Vakansavdrag { get; set; }
        public double Årsarbete { get; set; }

        [Required]
        public string Lösenord { get; set; }

        [Required]
        public string Behörighet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AntalTimmar> AntalTimmar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalProdukt> PersonalProdukt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalAktivitet> PersonalAktivitet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvdelningPersonalxRef> AvdelningPersonalxRef { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KostnadsbudgetSet> KostnadsbudgetSet { get; set; }
    }
}
