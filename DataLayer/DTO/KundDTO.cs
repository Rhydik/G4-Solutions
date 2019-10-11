using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DTO
{
    /* Används för att kunna bryta ut olika kolumner ur en tabell med LINQ. Utan denna populeras gridViewn med alla foreign keys med. */
    public class KundDTO
    {
        public int KundID { get; set; }
        public string Namn { get; set; }
        public string KundKategori { get; set; }
    }
}
