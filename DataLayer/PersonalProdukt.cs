namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonalProdukt")]
    public partial class PersonalProdukt
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Personal_PersonalID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Produkt_ProduktID { get; set; }

        public int Placeringsandel { get; set; }

        public virtual Personal Personal { get; set; }
    }
}
