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
                            select new SchablonDTO { Konto = x.Konto.konto1, Kontobenämning = x.Konto.Benämning, Belopp = x.Belopp};

                return query.ToList();
            }
        }

        public List<SchablonDTO> GetSchablonById(string id)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.schablonkostnad
                            where x.Konto.konto1.StartsWith(id)
                            select new SchablonDTO { Belopp = x.Belopp, Konto = x.Konto.konto1, Kontobenämning = x.Konto.Benämning };

                return query.ToList();
            }
        }

        public List<SchablonDTO> GetSchablonByBenämning(string benämning)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.schablonkostnad
                            where x.Konto.Benämning.StartsWith(benämning)
                            select new SchablonDTO { Belopp = x.Belopp, Konto = x.Konto.konto1, Kontobenämning = x.Konto.Benämning };

                return query.ToList();
            }
        }

        public void RemoveKonto(SchablonDTO schablon)
        {
            using (var db = new DataContext())
            {
                var kontoToRemove = (from x in db.Konto
                                     where x.konto1 == schablon.Konto
                                     select x).FirstOrDefault();

                var schablonen = db.schablonkostnad.Where(x => x.Konto.konto1 == schablon.Konto).FirstOrDefault();

                db.Konto.Remove(kontoToRemove);
                db.schablonkostnad.Remove(schablonen);
                
                db.SaveChanges();
            }
        }

        public void UpdateKonto(SchablonDTO oldSchablon, string kontot, string benämning, int schablonKostnad)
        {
            using (var db = new DataContext())
            {
                var tempkontot = (from x in db.Konto
                              where x.konto1 == kontot
                              select x).FirstOrDefault();


                Konto konto = new Konto { konto1 = kontot, Benämning = benämning, };
                db.Konto.Remove(tempkontot);
                db.Konto.Add(konto);

                var tempschablon = (from x in db.schablonkostnad
                                    where x.Konto.konto1 == kontot
                                    select x).FirstOrDefault();

                schablonkostnad schablon = new schablonkostnad { Konto = konto, Belopp = schablonKostnad, Konto_KontoID = konto.KontoID, };
                db.schablonkostnad.Remove(tempschablon);
                db.schablonkostnad.Add(schablon);

                db.SaveChanges();
            }
        }

        public void CreateKonto (int kontot, string benämning, int schablonKostnad)
        {
            using (var db = new DataContext())
            {
                var konto = new Konto { konto1 = kontot.ToString(), Benämning = benämning };
                db.Konto.Add(konto);

                var schablon = (from x in db.schablonkostnad
                                where x.Konto_KontoID == kontot
                                select x).FirstOrDefault();

                schablonkostnad newschablon = new schablonkostnad { Konto = konto, Belopp = schablonKostnad, Konto_KontoID = konto.KontoID };

                db.schablonkostnad.Add(newschablon);

                db.SaveChanges();
            }
        }

        public void CreateAvkastning(int avkastning)
        {
            using (var db = new DataContext())
            {
                var nyttkonto = new Konto { konto1 = "9999", Benämning = "Avkastningskrav" };
                var schablon = new schablonkostnad { schablonkostnadID = 9999, Konto = nyttkonto, Belopp = avkastning, Konto_KontoID = nyttkonto.KontoID};

                db.Konto.Add(nyttkonto);
                db.schablonkostnad.Add(schablon);

                db.SaveChanges();
            }
        }
    }
}
