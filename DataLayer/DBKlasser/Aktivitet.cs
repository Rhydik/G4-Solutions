namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aktivitet")]
    public partial class Aktivitet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aktivitet()
        {
            PersonalAktivitet = new HashSet<PersonalAktivitet>();
            DirektkostnadAktivitet = new HashSet<DirektkostnadAktivitet>();
        }
        [Key]
        [Column(TypeName = "VARCHAR", Order = 0)]
        [Index(IsUnique = true)]
        [StringLength(128)]
        public string AktivitetID { get; set; }

        
        [Column(Order = 1)]
        public string Namn { get; set; }

       
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Avdelning_AvdelningID { get; set; }

        public virtual Avdelning Avdelning { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalAktivitet> PersonalAktivitet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DirektkostnadAktivitet> DirektkostnadAktivitet { get; set; }

    }
}
