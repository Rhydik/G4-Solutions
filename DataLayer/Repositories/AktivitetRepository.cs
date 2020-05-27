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
        public List<AktivitetDTO> GetAllAktiviteter() //Hämtar samtliga aktiviteter
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Aktivitet
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn, Avdelning = x.Avdelning.Namn};
                return query.ToList();
            }
        }

        public List<AktivitetDTO> GetAktivitetById(string aktivitetId)  //Hämtar aktiviteter efter vald aktivtiets-ID
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Aktivitet
                            where x.AktivitetID.StartsWith(aktivitetId)
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn };

                return query.ToList();
            }
        }

        public void RemoveAktivitet(AktivitetDTO aktivitet)  //Raderar aktivitet
        {
            using (var db = new DataContext())
            {
                var aktiviteten = db.Aktivitet.Where(x => x.AktivitetID == aktivitet.AktivitetID).FirstOrDefault();
                var aktivitetsKostnad = db.DirektkostnadAktivitet.Where(x => x.Aktivitet_AktivitetID == aktiviteten.AktivitetID);
                var personalFördelningAktivitet = db.PersonalAktivitet.Where(x => x.Aktivitet_AktivitetID == aktiviteten.AktivitetID);

                db.PersonalAktivitet.RemoveRange(personalFördelningAktivitet);
                db.DirektkostnadAktivitet.RemoveRange(aktivitetsKostnad);
                db.Aktivitet.Remove(aktiviteten);
                db.SaveChanges();
            }
        }

        public List<AktivitetDTO> GetAktivitetByNamn(string aktivitetNamn) //Hämtar aktiviteter efter vald aktivitetsnamn
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Aktivitet
                            where x.Namn.StartsWith(aktivitetNamn)
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn };

                return query.ToList();
            }
        }

        public void UpdateAktivitet(string aktiId, string aktinamn, string aktiAvdelning) //Uppdaterar aktivitetsdatabasen
        {
            using (var db = new DataContext())
            {
                var tempAkti = (from x in db.Aktivitet
                           where x.AktivitetID == aktiId
                           select x).FirstOrDefault();

                var avdelning = (from x in db.Avdelning
                                 where x.Namn == aktiAvdelning
                                 select x).FirstOrDefault();

                var akti = new Aktivitet { AktivitetID = aktiId, Namn = aktinamn, Avdelning = avdelning, Avdelning_AvdelningID = avdelning.AvdelningID };
                db.Aktivitet.Remove(tempAkti);
                db.Aktivitet.Add(akti);
                db.SaveChanges();
            }
        }

        public void AddAktivitet(string aktvitetsId, string namn, string avdelning) //Lägger till ny aktivitet
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

        public List<AktivitetDTO> GetAktivitetByAvdelning(string avdelning) //Hämtar aktiviteter efter vald aktivitetsavdelning
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Aktivitet
                            where x.Avdelning.Namn.StartsWith(avdelning)
                            select new AktivitetDTO { AktivitetID = x.AktivitetID, Namn = x.Namn, Avdelning = x.Avdelning.Namn };

                return query.ToList();
            }
        }

        public void AddAvdelning(string namn) //Lägger till ny avdelning
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

        public List<AvdelningDTO> GetAllAvdelningar() //Hämtar samtliga avldelningar
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
