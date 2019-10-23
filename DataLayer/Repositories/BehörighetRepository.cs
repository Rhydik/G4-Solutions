using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BehörighetRepository
    {
        public List<BehörighetDTO> GetAllBehörighet()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            select new BehörighetDTO { Personnummer = x.PersonNr, Behörighet = x.Behörighet, Namn = x.Namn, };

                return query.ToList();
            }
        }

        public List<BehörighetDTO> GetBehörighetByPersnr(string persnr)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            where x.PersonNr.StartsWith(persnr)
                            select new BehörighetDTO { Behörighet = x.Behörighet, Namn = x.Namn, Personnummer = x.PersonNr };

                return query.ToList();
            }
        }

        public List<VisaBehörighetDTO> GetBehörighet(string persnr)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            where x.PersonNr == persnr
                            select new VisaBehörighetDTO { Behörighet = x.Behörighet };

                return query.ToList();
            }
        }

        public List<BehörighetDTO> GetBehörighetByNamn(string namn)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            where x.Namn.StartsWith(namn)
                            select new BehörighetDTO { Behörighet = x.Behörighet, Namn = x.Namn, Personnummer = x.PersonNr };

                return query.ToList();
            }
        }

        public void Addbehörighet(string tempBehör, string tempPersnr)
        {
            using (var db = new DataContext())
            {
                var personen = db.Personal.Where(x => x.PersonNr == tempPersnr).FirstOrDefault();

                personen.Behörighet = tempBehör;
                db.SaveChanges();
            }
        }

        public void RemoveBehörighet(string tempBehör, string tempPersnr)
        {
            using (var db = new DataContext())
            {
                var personen = db.Personal.Where(x => x.PersonNr == tempPersnr).FirstOrDefault();

                personen.Behörighet = "Basanvändare";
                db.SaveChanges();
            }
        }
    }
}
