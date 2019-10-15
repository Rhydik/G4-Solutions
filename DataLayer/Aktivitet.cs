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
        public int AktivitetID { get; set; }

        [Required]
        public string Namn { get; set; }

        public int Avdelning_AvdelningID { get; set; }

        public virtual Avdelning Avdelning { get; set; }
    }
}
