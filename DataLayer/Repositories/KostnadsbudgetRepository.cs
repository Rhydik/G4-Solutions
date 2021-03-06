﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DTO;

namespace DataLayer
{
    public class KostnadsbudgetRepository
    {
        public double PlaceringDiff;

        public List<string> GetAllAnvändaProdukter()
        {
            using (var db = new DataContext())
            {
                var personalprod = db.PersonalProdukt.Select(x => x.Produkt_ProduktID).Distinct().ToList();

                var direktprod = db.DirektkostnadProdukt.Select(x => x.Produkt_ProduktID).Distinct().ToList();

                personalprod.AddRange(direktprod);

                return personalprod;
            }

        }

        public List<KonstnadsbudgetPersonalDTO> GetKostnadsbudgetPersonal() //Hämtar personalkostnadslista
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            select new KonstnadsbudgetPersonalDTO { PersonalID = x.PersonalID, Namn = x.Namn, Sysselsättningsgrad = x.Sysselsättningsgrad, Vakansavdrag = x.Vakansavdrag, Årsarbetare = x.Sysselsättningsgrad - x.Vakansavdrag };

                return query.ToList();
            }
        }

        public List<KostnadsbudgetProduktDTO> GetKostnadsbudgetProdukt() //Hämtar kostnadsbudgeteringproduktlista
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt
                            select new KostnadsbudgetProduktDTO { Produkt = x.Namn, ProduktID = x.ProduktID, Avdelning_AvdelningID = x.Avdelning_AvdelningID };

                return query.ToList();
            }

        }

        
        public void LäggTillPlaceringAktivitet(int pers, string aktivitet, double andel) //Lägg till aktivitet
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
                temp.Placeringsandel = andel;
                temp.Aktivitet_AktivitetID = akti.AktivitetID;
                temp.Personal = perso;
                temp.Personal_PersonalID = perso.PersonalID;
                temp.Aktivitet = akti;
                db.PersonalAktivitet.Add(temp);
                db.SaveChanges();
            }
        }

        public List<DirektkostnadProduktDTO> GetAllDirektKostnadProdukt() //Hämtar direktakostnaderprodukt
        {
            using (var db = new DataContext())
            {
                var query = from x in db.DirektkostnadProdukt
                            select new DirektkostnadProduktDTO { Belopp = x.Belopp, Konto = x.Konto.Benämning, Kontonummer = x.Konto.konto1, Produkt = x.Produkt.Namn };

                return query.ToList();
            }
        }

        public void RemoveDirektKostnadAktivitet(DirektkostnadAktivitetDTO direktkostnad) //Raderar vald kostnadsaktivitet
        {
            using (var db = new DataContext())
            {
                var query = (from x in db.DirektkostnadAktivitet
                            where x.Belopp == direktkostnad.Belopp & x.Aktivitet.AktivitetID == direktkostnad.AktivitetID & x.Konto.konto1 == direktkostnad.Kontonummer
                            select x).FirstOrDefault();

                db.DirektkostnadAktivitet.Remove(query);
                db.SaveChanges();
            }
        }

        public void RemoveDirektKostnadProdukt(DirektkostnadProduktDTO direktkostnad) //Raderar vald produktkostnad
        {
            using (var db = new DataContext())
            {
                var query = (from x in db.DirektkostnadProdukt
                            where x.Belopp == direktkostnad.Belopp & x.Konto.konto1 == direktkostnad.Kontonummer & x.Produkt.Namn == direktkostnad.Produkt
                            select x).FirstOrDefault();

                db.DirektkostnadProdukt.Remove(query);
                db.SaveChanges();
            }
        }

        public List<DirektkostnadAktivitetDTO> GetAllDirektkostnadAktivitet() //Hämtar kostnadsaktivitetslista
        {
            using (var db = new DataContext())
            {
                var query = from x in db.DirektkostnadAktivitet
                            select new DirektkostnadAktivitetDTO { Aktivitet = x.Aktivitet.Namn, AktivitetID = x.Aktivitet_AktivitetID, Belopp = x.Belopp, Konto = x.Konto.Benämning, Kontonummer = x.Konto.konto1 };

                return query.ToList();
            }
        }

        public void AddDirektkostnadProdukt(string prod, string konto, string belopp) //Lägg till ny kostnad efter vald produkt
        {
            using (var db = new DataContext())
            {
                var produkt = (from x in db.Produkt
                               where x.Namn == prod
                               select x).FirstOrDefault();
                var kontot = (from x in db.Konto
                              where x.Benämning == konto
                              select x).FirstOrDefault();

                DirektkostnadProdukt DKP = new DirektkostnadProdukt();
                DKP.Produkt = produkt;
                DKP.Produkt_ProduktID = produkt.ProduktID;
                DKP.Konto = kontot;
                DKP.Konto_KontoID = kontot.KontoID;
                DKP.Belopp = double.Parse(belopp);

                db.DirektkostnadProdukt.Add(DKP);
                db.SaveChanges();
            }
        }

        public List<Produkt> GetProduktByProduktGrupp(ProduktgruppDTO produktgruppDTO) //Hämtar produkt efter vald grupp
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produktgrupp
                            join y in db.Produkt on x.ProduktgruppID equals y.Produktgrupp.ProduktgruppID
                            select y;

                return query.ToList();
            }
        }

        public void AddDirektkostnadAktivitet(string akti, string konto, string belopp) //Lägg till ny kostnad efter vald aktivitet
        {
            using (var db = new DataContext())
            {
                var akitvitet = (from x in db.Aktivitet
                                where x.Namn == akti
                                select x).FirstOrDefault();
                var kontot = (from x in db.Konto
                              where x.Benämning == konto
                              select x).FirstOrDefault();

                DirektkostnadAktivitet DKA = new DirektkostnadAktivitet();
                DKA.Aktivitet = akitvitet;
                DKA.Aktivitet_AktivitetID = akitvitet.AktivitetID;
                DKA.Belopp = double.Parse(belopp);
                DKA.Konto = kontot;
                DKA.Konto_KontoID = kontot.KontoID;

                db.DirektkostnadAktivitet.Add(DKA);
                db.SaveChanges();
            }
        }

        public List<PersonalAktivitetDTO> GetAllPersonalAktivitet() //Hämtar personallista
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

        public void RemovePlaceringAktivitet(string pers, string aktivitet, double andel) //Raderar vald placeringsaktivitet
        {
            using (var db = new DataContext())
            {
                var akti = (from x in db.Aktivitet
                            where x.Namn == aktivitet
                            select x).FirstOrDefault();

                var query = (from x in db.PersonalAktivitet
                             where x.Placeringsandel == andel & x.Personal.Namn == pers & x.Aktivitet_AktivitetID == akti.AktivitetID
                             select x).FirstOrDefault();

                db.PersonalAktivitet.Remove(query);

                db.SaveChanges();
            }
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
                item.Fpp = GetFördeladAndel(item.PersonalID);
                
                //item.Andel = 100;
                
                item.Totalt = item.Årsarbetare;
                item.Diff = item.Totalt - GetFördeladAndel(item.PersonalID);

                PlaceringDiff = item.Diff;

                Console.WriteLine(PlaceringDiff);

                //item.GemAdm = 0;
            }
            return personals;

        }

        public double GetDiff(List<KonstnadsbudgetPersonalDTO> personals)
        {
            double Diffen;
            Diffen = PlaceringDiff;

            return Diffen;
        }

    public double GetFördeladAndel(int personal) //Beräknar placerings andel efter vald personal
        {
            using (var db = new DataContext())
            {
                double total = 0;

                var andelaktivitet = from x in db.PersonalAktivitet
                            where x.Personal_PersonalID == personal
                            select x.Placeringsandel;
                foreach (var item in andelaktivitet)
                {
                    total += item;
                }
                var andelprodukt = from x in db.PersonalProdukt
                                   where x.Personal_PersonalID == personal
                                   select x.Placeringsandel;
                foreach (var item in andelprodukt)
                {
                    total += item;
                }

                return total;
            }
        }

        public List<DTO.BudgetKontoDTO> GetAllKonton() //Hämtar kontolista
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Konto
                            orderby x.Benämning
                            select new DTO.BudgetKontoDTO {Benämning = x.Benämning , Konto = x.konto1, KontoID = x.KontoID };
                        return query.ToList();
            }
        }

        public void LäggTillPlaceringProdukt(int personal, string produkt, double andel) //Lägg till placering efter vald produkt
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
                temp.Placeringsandel = andel;
                temp.Produkt_ProduktID = prod.ProduktID;

                db.PersonalProdukt.Add(temp);
                db.SaveChanges();
            }
        }

        public List<PersonalProduktDTO> GetAllPersonalProdukt() //Hämtar personal efter vald produkt
        {
            using (var db = new DataContext())
            {
                var query = from x in db.PersonalProdukt
                            from y in db.Produkt
                            where y.ProduktID == x.Produkt_ProduktID
                            select new PersonalProduktDTO { Personnummer = x.Personal.PersonNr, Personal = x.Personal.Namn, Placeringsandel = x.Placeringsandel, Produkt = y.Namn };

                return query.ToList();
            }
        }

        public void RemovePlaceringsProdukt(string pers, string produkt, double andel) //Raderar vald produktplacering
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
