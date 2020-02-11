using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DTO;

namespace DataLayer
{
    public class KostnadsbudgetRepository
    {
        public List<KonstnadsbudgetPersonalDTO> GetKostnadsbudgetPersonal()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            select new KonstnadsbudgetPersonalDTO { PersonalID = x.PersonalID, Namn = x.Namn, Sysselsättningsgrad = x.Sysselsättningsgrad, Vakansavdrag = x.Vakansavdrag, Årsarbetare = x.Sysselsättningsgrad - x.Vakansavdrag };

                return query.ToList();
            }
        }

        public List<KostnadsbudgetProduktDTO> GetKostnadsbudgetProdukt()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt
                            select new KostnadsbudgetProduktDTO { Produkt = x.Namn, ProduktID = x.ProduktID, Avdelning_AvdelningID = x.Avdelning_AvdelningID };

                return query.ToList();
            }

        }

        public void LäggTillPlaceringAktivitet(int pers, string aktivitet, string andel)
        {
            using (var db = new DataContext())
            {
                var perso = (from x in db.Personal
                            where x.PersonalID == pers
                            select x).FirstOrDefault();
                var akti = (from x in db.Aktivitet
                            where x.Namn == aktivitet
                            select x).FirstOrDefault();

                PersonalAktivitet temp = new PersonalAktivitet();
                temp.Aktivitet_AktivitetID = akti.AktivitetID;
                temp.Personal = perso;
                temp.Personal_PersonalID = perso.PersonalID;
                temp.Aktivitet = akti;
                temp.Placeringsandel = int.Parse(andel);
                db.PersonalAktivitet.Add(temp);
                db.SaveChanges();
            }
        }

        public List<PersonalAktivitetDTO> GetAllPersonalAktivitet()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.PersonalAktivitet
                            from y in db.Aktivitet
                            where y.AktivitetID == x.Aktivitet_AktivitetID
                            select new PersonalAktivitetDTO { Personal = x.Personal.Namn, Placeringsandel = x.Placeringsandel, Aktivitet = y.Namn };

                return query.ToList();
            }
        }

        public void RemovePlaceringAktivitet(string pers, string aktivitet, int andel)
        {
            //using (var db = new DataContext())
            //{
            //    var prod = (from x in db.Aktivitet
            //                where x.Namn == aktivitet
            //                select x).FirstOrDefault();

            //    var query = (from x in db.PersonalAktivitet
            //                 where x.Placeringsandel == andel & x.Personal.Namn == pers & x.Aktivitet_AktivitetID == prod.AktivitetID
            //                 select x).FirstOrDefault();

            //    db.PersonalAktivitet.Remove(query);

            //    db.SaveChanges();
            //}
        }


        /// <summary>
        /// I kalkyleringen skall vi genomföra algoritmen för att räkna ut de följande värdena : andel,diff, totalt etc...
        /// Kolla gärna KostnadsBudgetPersonalDTO samt prototyp/dokumentation för vidare förklaring av vad variablerna står för.
        /// 
        /// </summary>
        /// <param name="personals"></param>
        /// <returns></returns>
        public List<KonstnadsbudgetPersonalDTO> Kalkylering(List<KonstnadsbudgetPersonalDTO> personals)
        {
            foreach (var item in personals)
            {

                //vi ska uppdatera logiken här, detta är bara tillfälligt
                item.Vakansavdrag = 100 - item.Årsarbetare; //100% - hur mkt de jobbat = hur mycket de behöver i vakans
                item.Andel = 0;
                item.Diff = 0;
                item.Totalt = 0;
                item.GemAdm = 0;
                item.Fpp = 0;
            }
            return personals;

        }

        public List<DTO.BudgetKontoDTO> GetAllKonton()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Konto
                            orderby x.Benämning
                            select new DTO.BudgetKontoDTO {Benämning = x.Benämning , Konto = x.konto1, KontoID = x.KontoID };
                        return query.ToList();
            }
        }

        public void LäggTillPlaceringProdukt(int personal, string produkt, string andel)
        {
            using (var db = new DataContext())
            {
                var pers = (from x in db.Personal
                            where x.PersonalID == personal
                            select x).FirstOrDefault();
                var prod = (from x in db.Produkt
                            where x.Namn == produkt
                            select x).FirstOrDefault();

                PersonalProdukt temp = new PersonalProdukt();
                temp.Personal = pers;
                temp.Placeringsandel = int.Parse(andel);
                temp.Produkt_ProduktID = prod.ProduktID;

                db.PersonalProdukt.Add(temp);

                db.SaveChanges();
            }
        }

        public List<PersonalProduktDTO> GetAllPersonalProdukt()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.PersonalProdukt
                            from y in db.Produkt where y.ProduktID == x.Produkt_ProduktID
                            select new PersonalProduktDTO { Personal = x.Personal.Namn, Placeringsandel = x.Placeringsandel, Produkt = y.Namn };

                return query.ToList();
            }
        }

        public void RemovePlaceringsProdukt(string pers, string produkt, int andel)
        {
            using (var db = new DataContext())
            {
                var prod = (from x in db.Produkt
                            where x.Namn == produkt
                            select x).FirstOrDefault();

                var query = (from x in db.PersonalProdukt
                             where x.Placeringsandel == andel & x.Personal.Namn == pers & x.Produkt_ProduktID == prod.ProduktID
                             select x).FirstOrDefault();

                db.PersonalProdukt.Remove(query);
                         
                db.SaveChanges();
            }
        }
    }
}
