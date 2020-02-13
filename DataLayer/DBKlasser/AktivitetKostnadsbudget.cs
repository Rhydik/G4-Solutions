namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AktivitetKostnadsbudget")]
    public partial class AktivitetKostnadsbudget
    {
        [Key]
        [Column(Order = 0)]
        public string Aktivitet_AktivitetID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kostnadsbudget_KostnadsbudgetID { get; set; }

        public virtual KostnadsbudgetSet KostnadsbudgetSet { get; set; }
    }
}
