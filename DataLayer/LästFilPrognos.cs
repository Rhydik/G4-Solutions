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
        public decimal Budget { get; set; }

        public decimal UtfallMån { get; set; }
        public decimal UtfallAcc { get; set; }
        public string Månad { get; set; }
        public decimal Upparbetat { get; set; }
        public decimal Trend { get; set; }
        public decimal FöregPrognos { get; set; }
        public decimal Prognos { get; set; }
        public decimal PrognosBudget { get; set; }
        
    }
}
