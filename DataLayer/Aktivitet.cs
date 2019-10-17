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
        [Key]
        [Column(Order = 0)]
        public string AktivitetID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Namn { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Avdelning_AvdelningID { get; set; }

        public virtual Avdelning Avdelning { get; set; }
    }
}
