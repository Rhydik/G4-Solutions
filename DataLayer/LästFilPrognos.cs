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
        public string Budget { get; set; }

        public string UtfallMån { get; set; }
        public string UtfallAcc { get; set; }
        public string Månad { get; set; }
        public string Upparbetat { get; set; }
        public string Trend { get; set; }
        public string FöregPrognos { get; set; }
        public string Prognos { get; set; }
        public decimal PrognosBudget { get; set; }
        
    }
}
