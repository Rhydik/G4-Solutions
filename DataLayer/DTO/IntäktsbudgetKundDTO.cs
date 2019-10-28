using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class IntäktsbudgetKundDTO
    {
        public string ProduktID { get; set; }
        public string ProduktNamn { get; set; }
        public decimal Avtal { get; set; }
        public bool GradA { get; set; }
        public decimal Tillägg { get; set; }
        public bool GradT { get; set; }
        public decimal Budget { get; set; }
        public int Tim { get; set; }
        public string Kommentar { get; set; }
    }
}
