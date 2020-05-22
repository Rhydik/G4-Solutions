using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LästFilPrognos
    {
        public string ProduktID { get; set; }
        public string Produkt { get; set; }
        public string KundID { get; set; }
        public string Kund { get; set; }
        public string Datum { get; set; }
        public double Budget { get; set; }

        public double UtfallMån { get; set; }
        public double UtfallAcc { get; set; }
        public string Månad { get; set; }
        public double Upparbetat { get; set; }
        public double Trend { get; set; }
        public double FöregPrognos { get; set; }
        public double Prognos { get; set; }
        public double PrognosBudget { get; set; }
        
    }
}
