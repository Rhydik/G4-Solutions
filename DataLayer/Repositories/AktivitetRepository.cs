using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AktivitetRepository
    {
        public List<AktivitetDTO> GetAllAktiviteter()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Aktivitet
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn };
                return query.ToList();
            }
        }

        public object GetAktivitetById(string aktivitetId)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Aktivitet
                            where x.AktivitetID.StartsWith(aktivitetId)
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn };

                return query.ToList();
            }
        }

        public object GetAktivitetByNamn(string aktivitetNamn)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Aktivitet
                            where x.Namn.StartsWith(aktivitetNamn)
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn };

                return query.ToList();
            }
        }

        public void AddAktivitet(string aktvitetsId, string namn, string avdelning)
        {
            using (var db = new DataContext())
            {
                var Avdelning = (from x in db.Avdelning
                                 where x.Namn == avdelning
                                 select x).FirstOrDefault();

                var aktivitet = new Aktivitet { Namn = namn, AktivitetID = aktvitetsId, Avdelning = Avdelning, };
                db.Aktivitet.Add(aktivitet);
                db.SaveChanges();
            }
        }

        public object GetAktivitetByAvdelning(string avdelning)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Aktivitet
                            where x.Avdelning.ToString().StartsWith(avdelning)
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn };

                return query.ToList();
            }
        }
    }
}
