using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Table("Lås")]
    public class Lås
    {
        [Key]

        public int LåsID { get; set; }
        public bool Intäktsbudget { get; set; }
        public bool Kostnadsbudget { get; set; }

    }
}
