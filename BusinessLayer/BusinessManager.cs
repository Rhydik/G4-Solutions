using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BusinessManager
    {
        public List<Kund> GetKunder()
        {
            List<Kund> kunder = new List<Kund>();
            foreach (DataLayer.Kund kund in Class1.GetKunder())
            {
                kunder.Add(new Kund(kund));
            }
            return kunder;
        }
    }
}
