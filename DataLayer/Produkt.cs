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
        public Produkt()
        {
            DirektkostnadProdukt = new HashSet<DirektkostnadProdukt>();
        }

        [Key]
        [Column(TypeName = "VARCHAR", Order = 0)]
        [Index(IsUnique = true)]
        [StringLength(128)]
        public string ProduktID { get; set; }

        [Column(Order = 1)]
        public string Namn { get; set; }

        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Produktkategori_ProduktkategoriID { get; set; }

        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Produktgrupp_ProduktgruppID { get; set; }

        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Avdelning_AvdelningID { get; set; }

        public virtual Avdelning Avdelning { get; set; }

        public virtual Produktgrupp Produktgrupp { get; set; }

        public virtual Produktkategori Produktkategori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DirektkostnadProdukt> DirektkostnadProdukt { get; set; }
    }
}
