namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DirektkostnadProdukt")]
    public partial class DirektkostnadProdukt
    {
        [Key]
        [Column(Order = 0)]
        public int Konto_KontoID { get; set; }
        public virtual Konto Konto { get; set; }

        [Key]
        [Column(TypeName = "VARCHAR", Order = 1)]
        [StringLength(128)]
        public string Produkt_ProduktID { get; set; }
        public virtual Produkt Produkt { get; set; }
        public decimal Belopp { get; set; }
    }
}
