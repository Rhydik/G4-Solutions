namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kund")]
    public partial class Kund
    {
        [Key]
        [Column(Order = 0)]
        public string KundID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Namn { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KundKategori_KundKategoriID { get; set; }

        public virtual KundKategori KundKategori { get; set; }
    }
}
