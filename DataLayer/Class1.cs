using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Class1
    {
        public static List<Kund> GetKunder()
        {
            using (var db = new Database())
            {
                return db.Kund.ToList();
            }
        }
    }
}
