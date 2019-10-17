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
        public int Sysselsättningsgrad { get; set; }
        public string Namn { get; set; }
        public string PersonNr { get; set; }
        public int Vakansavdrag { get; set; }
    }
}
