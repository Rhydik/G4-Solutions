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
            Avdelning = new HashSet<Avdelning>();
            Produkt = new HashSet<Produkt>();
        }

        public int PersonalID { get; set; }

        [Required]
        public string PersonNr { get; set; }

        [Required]
        public string Namn { get; set; }

        public int Månadslön { get; set; }

        public int Sysselsättningsgrad { get; set; }

        public int Vakansavdrag { get; set; }

        [Required]
        public string Lösenord { get; set; }

        [Required]
        public string Behörighet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AntalTimmar> AntalTimmar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avdelning> Avdelning { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produkt> Produkt { get; set; }
    }
}
