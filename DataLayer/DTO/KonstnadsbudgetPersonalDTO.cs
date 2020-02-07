using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class KonstnadsbudgetPersonalDTO
    {
        public int PersonalID { get; set; }
        public string Namn { get; set; }
        public decimal Sysselsättningsgrad { get; set; }
        public decimal Vakansavdrag { get; set; }
        public decimal Årsarbetare { get; set; }
        public decimal Andel { get; set; } //Konto 521 Andel i budget % 
        public decimal Diff { get; set; } //Differens
        public decimal Totalt { get; set; } //Totalt 
        public decimal GemAdm { get; set; } //Gem. Adm.
        public decimal Fpp { get; set; } //Fördelat På Produkter

    }
}
