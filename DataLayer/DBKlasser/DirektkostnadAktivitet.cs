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
        public int Konto_KontoID { get; set; }
        public virtual Konto Konto { get; set; }

        [Key]
        [Column(TypeName = "VARCHAR", Order = 1)]
        [StringLength(128)]
        public string Aktivitet_AktivitetID { get; set; }
        public virtual Aktivitet Aktivitet { get; set; }
        public double Belopp { get; set; }
    }
}
