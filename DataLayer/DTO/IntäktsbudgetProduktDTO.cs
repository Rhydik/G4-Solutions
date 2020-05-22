using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DTO
{
    public class IntäktsbudgetProduktDTO
    {
        public int IntäktsbudgetID { get; set; }
        public string KundID { get; set; }
        public string KundNamn { get; set; }
        public double Avtal { get; set; }
        public bool GradA { get; set; }
        public double Tillägg { get; set; }
        public bool GradT { get; set; }
        public double Budget { get; set; }
        public int Tim { get; set; }
        public string Kommentar { get; set; }
    }
}
