using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Table("DirektkostnadAktivitet")]
    public class DirektkostnadAktivitet
    {
        [Key]
        [Column(Order = 0)]
        public int Direktkostnad_DirektkostnadID { get; set; }
        public Direktkostnad Direktkostnad { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Aktivitet_AktivitetID { get; set; }
        public Aktivitet Aktivitet { get; set; }
        public decimal Belopp { get; set; }
    }
}
