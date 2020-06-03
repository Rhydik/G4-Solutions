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
        public double Månadslön { get; set; }
        public double Sysselsättningsgrad { get; set; }
        public double Vakansavdrag { get; set; }
        public double Årsarbete { get; set; }
        public string Lösenord { get; set; }
    }
}
