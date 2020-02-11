using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DirektkostnadProduktDTO
    {
        public string Kontonummer { get; set; }
        public string Konto { get; set; }
        public string Produkt { get; set; }
        public decimal Belopp { get; set; }
    }
}
