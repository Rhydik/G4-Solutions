using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class KostnadsbudgetRepository
    {
        public List<KonstnadsbudgetPersonalDTO> GetKostnadsbudgetPersonal()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            select new KonstnadsbudgetPersonalDTO { Namn = x.Namn, Sysselsättningsgrad = x.Sysselsättningsgrad, Vakansavdrag = x.Vakansavdrag, Årsarbetare = x.Sysselsättningsgrad - x.Vakansavdrag };

                return query.ToList();
            }
        }

        public List<KostnadsbudgetProduktDTO> GetKostnadsbudgetProdukt()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt
                            select new KostnadsbudgetProduktDTO { Produkt = x.Namn, ProduktID = x.ProduktID, };

                return query.ToList();
            }

        }
    }
}
