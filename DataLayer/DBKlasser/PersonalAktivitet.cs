using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Table("PersonalAktivitet")]
    public partial class PersonalAktivitet
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Personal_PersonalID { get; set; }

        [Key]
        [Column(TypeName = "VARCHAR", Order = 1)]
        [StringLength(128)]
        public string Aktivitet_AktivitetID { get; set; }

        public double Placeringsandel { get; set; }

        public virtual Personal Personal { get; set; }
        public virtual Aktivitet Aktivitet { get; set; }
    }
}
