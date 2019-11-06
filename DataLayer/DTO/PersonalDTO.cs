using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DTO
{
    public class PersonalDTO
    {
        public int PersonalID { get; set; }
        public string PersonNr { get; set; }
        public string Namn { get; set; }
        public decimal Månadslön { get; set; }
        public decimal Sysselsättningsgrad { get; set; }
        public decimal Vakansavdrag { get; set; }
        public decimal Årsarbete { get; set; }
    }
}
