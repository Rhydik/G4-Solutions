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

        public void RemoveKonto(SchablonDTO schablon)
        {
            using (var db = new DataContext())
            {
                var kontoToRemove = (from x in db.Konto
                                     where x.KontoID == schablon.KontoID
                                     select x).FirstOrDefault();

                var schablonen = db.schablonkostnad.Where(x => x.Konto.KontoID == schablon.KontoID).FirstOrDefault();

                db.Konto.Remove(kontoToRemove);
                db.schablonkostnad.Remove(schablonen);
                
                db.SaveChanges();
            }
        }

        public void UpdateKonto(SchablonDTO oldSchablon, int konto, string namn, int schablonKostnad)
        {
            using (var db = new DataContext())
            {
                var schablonen = (from x in db.schablonkostnad
                                    where x.Konto.Namn == namn
                                    select x).FirstOrDefault();

                var tempSchablon = (from x in db.schablonkostnad
                                where x.Konto.KontoID == oldSchablon.KontoID
                                select x).FirstOrDefault();

                

                var schablon = new schablonkostnad { schablonkostnadID = konto, Namn = namn, Belopp = schablonKostnad, Konto_KontoID = tempSchablon.Konto_KontoID};
                db.schablonkostnad.Remove(tempSchablon);
                db.schablonkostnad.Add(schablon);

                db.SaveChanges();
            }
        }

        public void CreateKonto (int konto, string namn, int schablonKostnad)
        {
            using (var db = new DataContext())
            {
                var schablonen = (from x in db.schablonkostnad
                                    where x.Konto.Namn == namn
                                    select x).FirstOrDefault();

                var schablon = new schablonkostnad { schablonkostnadID = konto, Namn = namn, Belopp = schablonKostnad, Konto_KontoID = konto };
                var nyttkonto = new Konto { KontoID = konto, Namn = namn};

                db.Konto.Add(nyttkonto);
                db.schablonkostnad.Add(schablon);

                db.SaveChanges();
            }
        }

        public void CreateAvkastning(int avkastning)
        {
            using (var db = new DataContext())
            {
                var schablon = new schablonkostnad { schablonkostnadID = 9999, Namn = "Avkastning", Belopp = avkastning, Konto_KontoID = 9999 };
                var nyttkonto = new Konto { KontoID = 9999, Namn = "Avkastning" };

                var kontoToRemove = (from x in db.Konto
                                     where x.Namn == schablon.Namn
                                     select x).FirstOrDefault();

                var schablonToRemove = db.schablonkostnad.Where(x => x.Konto.Namn == schablon.Namn).FirstOrDefault();


                db.Konto.Remove(kontoToRemove);
                db.schablonkostnad.Remove(schablonToRemove);

                
                db.Konto.Add(nyttkonto);
                db.schablonkostnad.Add(schablon);

                db.SaveChanges();
            }
        }

    }
}
