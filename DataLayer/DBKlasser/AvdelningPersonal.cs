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
        public virtual Avdelning Avdelning { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Personal_PersonalID { get; set; }
        public virtual Personal Personal { get; set; }
        public decimal Placering { get;set; }
    }
}
