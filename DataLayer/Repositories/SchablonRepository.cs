using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SchablonRepository
    {
        public List<SchablonDTO> GetAllSchablon() //Hämtar samtliga konton
        {
            using (var db = new DataContext())
            {
                var query = from x in db.schablonkostnad
                            select new SchablonDTO { Konto = x.Konto.konto1, Kontobenämning = x.Konto.Benämning, Belopp = x.Belopp };

                return query.ToList();
            }
        }

        public List<SchablonDTO> GetSchablonById(int id) //Hämtar konto efter vald konto-ID
        {
            using (var db = new DataContext())
            {
                var query = from x in db.schablonkostnad
                            where x.Konto.konto1 == id
                            select new SchablonDTO { Belopp = x.Belopp, Konto = x.Konto.konto1, Kontobenämning = x.Konto.Benämning };

                return query.ToList();
            }
        }

        public List<SchablonDTO> GetSchablonByBenämning(string benämning) //Hämtar konto efter vald kontobenämning
        {
            using (var db = new DataContext())
            {
                var query = from x in db.schablonkostnad
                            where x.Konto.Benämning.StartsWith(benämning)
                            select new SchablonDTO { Belopp = x.Belopp, Konto = x.Konto.konto1, Kontobenämning = x.Konto.Benämning };

                return query.ToList();
            }
        }

        public void AddSchablon(string kostnad, SchablonDTO schablon) //Lägg till ny schablonkostnad efter vald konto
        {
            using (var db = new DataContext())
            {
                var currentSchablon = (from x in db.schablonkostnad
                                       where x.Konto.konto1 == schablon.Konto
                                       select x).FirstOrDefault();
                if (currentSchablon != null)
                {
                    var newschablon = new schablonkostnad { Belopp = int.Parse(kostnad), Konto = currentSchablon.Konto, Konto_KontoID = currentSchablon.Konto_KontoID };
                    db.schablonkostnad.Remove(currentSchablon);
                    db.schablonkostnad.Add(newschablon);
                    db.SaveChanges();
                }
                else
                {
                    var kontot = (from x in db.Konto
                                 where x.konto1== schablon.Konto
                                 select x).FirstOrDefault();

                    var newschablon = new schablonkostnad { Belopp = int.Parse(kostnad), Konto = kontot, Konto_KontoID = kontot.KontoID };
                    db.schablonkostnad.Add(newschablon);
                    db.SaveChanges();
                }
            }
        }

        public void RemoveKonto(SchablonDTO schablon) //Radera vald konto
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

        public void UpdateKonto(SchablonDTO oldSchablon, int kontot, string benämning ) //Uppdaterar kontodatabasen
        {
            using (var db = new DataContext())
            {
                var tempschablon = (from x in db.schablonkostnad
                                    where x.Konto.konto1 == oldSchablon.Konto
                                    select x).FirstOrDefault();
                db.schablonkostnad.Remove(tempschablon);
                var tempkontot = (from x in db.Konto
                              where x.konto1 == oldSchablon.Konto
                              select x).FirstOrDefault();
                db.Konto.Remove(tempkontot);
                db.SaveChanges();


                Konto newKonto = new Konto { konto1 = kontot, Benämning = benämning, };
                schablonkostnad newSchablon = new schablonkostnad { Konto = newKonto, Belopp = oldSchablon.Belopp, Konto_KontoID = newKonto.KontoID };
                db.Konto.Add(newKonto);
                db.schablonkostnad.Add(newSchablon);

                db.SaveChanges();
            }
        }

        public void CreateKonto (int kontot, string benämning) //Lägg till ny konto
        {
            using (var db = new DataContext())
            {
                var konto = new Konto { konto1 = kontot, Benämning = benämning };
                db.Konto.Add(konto);

                var schablon = (from x in db.schablonkostnad
                                where x.Konto_KontoID == kontot
                                select x).FirstOrDefault();

                schablonkostnad newschablon = new schablonkostnad { Konto = konto, Belopp = 0, Konto_KontoID = konto.KontoID };

                db.schablonkostnad.Add(newschablon);

                db.SaveChanges();
            }
        }

        public void CreateAvkastning(int avkastning) 
        {
            using (var db = new DataContext())
            {
                var nyttkonto = new Konto { konto1 = 9999, Benämning = "Avkastningskrav" };
                var schablon = new schablonkostnad { schablonkostnadID = 9999, Konto = nyttkonto, Belopp = avkastning, Konto_KontoID = nyttkonto.KontoID};

                db.Konto.Add(nyttkonto);
                db.schablonkostnad.Add(schablon);

                db.SaveChanges();
            }
        }
    }
}
