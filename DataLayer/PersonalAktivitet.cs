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
        [Column(Order = 1)]
        public string Aktivitet_AktivitetID { get; set; }

        public int Placeringsandel { get; set; }

        public virtual Personal Personal { get; set; }
    }
}
