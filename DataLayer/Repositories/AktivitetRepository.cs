using DataLayer.DTO;
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
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn, Avdelning = x.Avdelning.Namn};
                return query.ToList();
            }
        }

        public List<AktivitetDTO> GetAktivitetById(string aktivitetId)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Aktivitet
                            where x.AktivitetID.StartsWith(aktivitetId)
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn };

                return query.ToList();
            }
        }

        public void RemoveAktivitet(AktivitetDTO aktivitet)
        {
            using (var db = new DataContext())
            {
                var aktiviteten = db.Aktivitet.Where(x => x.AktivitetID == aktivitet.AktivitetID).FirstOrDefault();
                db.Aktivitet.Remove(aktiviteten);
                db.SaveChanges();
            }
        }

        public List<AktivitetDTO> GetAktivitetByNamn(string aktivitetNamn)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Aktivitet
                            where x.Namn.StartsWith(aktivitetNamn)
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn };

                return query.ToList();
            }
        }

        public void UpdateAktivitet(string aktiId, string aktinamn, string aktiAvdelning)
        {
            using (var db = new DataContext())
            {
                var akti = (from x in db.Aktivitet
                           where x.AktivitetID == aktiId
                           select x).FirstOrDefault();

                akti.Namn = aktinamn;
                akti.AktivitetID = aktiId;
                akti.Avdelning.Namn = aktiAvdelning;
                db.SaveChanges();
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

        public List<AktivitetDTO> GetAktivitetByAvdelning(string avdelning)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Aktivitet
                            where x.Avdelning.Namn.StartsWith(avdelning)
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn, Avdelning = x.Avdelning.Namn };

                return query.ToList();
            }
        }

        public void AddAvdelning(string namn)
        {
            using (var db = new DataContext())
            {
                //var Avdelning = (from x in db.Avdelning
                //                 where x.Namn == avdelning
                //                 select x).FirstOrDefault();

                var avdelning = new Avdelning { Namn = namn };
                db.Avdelning.Add(avdelning);
                db.SaveChanges();
            }
        }

        public List<AvdelningDTO> GetAllAvdelningar()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Avdelning
                            select new AvdelningDTO { AvdelningsID = x.AvdelningID, Namn = x.Namn };

                return query.ToList();
            }
        }
    }
}
