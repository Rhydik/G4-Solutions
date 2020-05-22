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
        public double Sysselsättningsgrad { get; set; }
        public double Vakansavdrag { get; set; }
        public double Årsarbetare { get; set; }
        public double Andel { get; set; } //Konto 521 Andel i budget % 
        public double Diff { get; set; } //Differens
        public double Totalt { get; set; } //Totalt 
        public double GemAdm { get; set; } //Gem. Adm.
        public double Fpp { get; set; } //Fördelat På Produkter

    }
}
