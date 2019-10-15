namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produkt")]
    public partial class Produkt
    {
        [Key]
        [Column(Order = 0)]
        public string ProduktID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Namn { get; set; }

        public int? Intäktsbudget_IntäktsbudgetID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Produktkategori_ProduktkategoriID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Produktgrupp_ProduktgruppID { get; set; }

        public virtual Intäktsbudget Intäktsbudget { get; set; }

        public virtual Produktgrupp Produktgrupp { get; set; }

        public virtual Produktkategori Produktkategori { get; set; }
    }
}
