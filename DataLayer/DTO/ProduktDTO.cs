using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DTO
{
    public class ProduktDTO
    {
            public string ProduktID { get; set; }
            public string Namn { get; set;}
            public Produktgrupp Produktgrupp { get; set; }
            public Produktkategori Produktkategori { get; set; }

    }
}
