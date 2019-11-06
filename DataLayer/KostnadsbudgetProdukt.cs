namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KostnadsbudgetProdukt")]
    public partial class KostnadsbudgetProdukt
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kostnadsbudget_KostnadsbudgetID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Produkt_ProduktID { get; set; }

        public virtual KostnadsbudgetSet KostnadsbudgetSet { get; set; }
    }
}
