using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SchablonRepository
    {
        public List<SchablonDTO> GetAllSchablon()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.schablonkostnad
                            select new SchablonDTO { Belopp = x.Belopp, KontoID = x.Konto_KontoID, Namn = x.Namn };

                return query.ToList();
            }
        }

        public object GetSchablonById(string id)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.schablonkostnad
                            where x.Konto_KontoID.ToString().StartsWith(id)
                            select new SchablonDTO { Belopp = x.Belopp, KontoID = x.Konto_KontoID, Namn = x.Namn };

                return query.ToList();
            }
        }

        public object GetSchablonByBenämning(string benämning)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.schablonkostnad
                            where x.Namn.StartsWith(benämning)
                            select new SchablonDTO { Belopp = x.Belopp, KontoID = x.Konto_KontoID, Namn = x.Namn };

                return query.ToList();
            }
        }
    }
}
