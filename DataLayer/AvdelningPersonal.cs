using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Table("AvdelningPersonalxRef")]
    public class AvdelningPersonalxRef
    {
        [Key]
        [Column(Order = 0)]
        public int Avdelning_AvdelningID { get; set; }
        public Avdelning Avdelning { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Personal_PersonalID { get; set; }
        public Personal Personal { get; set; }
        public int Placering { get;set; }
    }
}
