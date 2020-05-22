using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DTO;


namespace DataLayer
{
    public class BudgeteratResultatRepository
    {
        decimal totaltillverkningskostnad;
        decimal sistaberäknadschablon;
        decimal lön;
        decimal andel;
        decimal lönresultat;
        //decimal beräknadschablon;
        private IQueryable<PersonalProdukt> personalkostnad;
        decimal totalandel;
        decimal kostnader;
        decimal totalkostnad;
        decimal pålägg;
        private Produkt produkten;
        decimal noll;
        decimal resultat;
        decimal säljavd;
        decimal adminavd;
        decimal direktkostnadersälj;
        decimal direktkostnaderadmin;
        private IQueryable<Personal> årsarbete;
        private IQueryable<Personal> till5021;
        private decimal årsarbeteresultat;
        private IQueryable<schablonkostnad> schablonskonstnad;
        private decimal schablonresultat;
        private decimal avkastningskrav;
        private IQueryable<DirektkostnadAktivitet> querykostnadadmin;
        private IQueryable<DirektkostnadAktivitet> querykostnadsälj;
        private IQueryable<AvdelningPersonalxRef> queryadmin;
        private IQueryable<AvdelningPersonalxRef> querysälj;
        private IQueryable<DirektkostnadProdukt> dkprodukter;

        public List<ProduktSummeringDTO> GetProduktIntäkter(ProduktDTO produkt) //Sätter ihop Produktlistan med Intäktslistan
        {
            using (var db = new DataContext())
            {
                var query = from x in db.ProduktIntäktsbudget
                            where x.Produkt_ProduktID == produkt.ProduktID
                            join y in db.Intäktsbudget on x.Intäktsbudget_IntäktsbudgetID equals y.IntäktsbudgetID
                            select new ProduktSummeringDTO { Budget = y.Budget };

                return query.ToList();
            }
        }

        public List<ProduktSummeringDTO> GetGruppIntäkter(ProduktgruppDTO produktgruppDTO) //Sätter ihop Produktlistan med Intäktsbudgetlista.
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt
                            where x.Produktgrupp_ProduktgruppID == produktgruppDTO.ProduktgruppID
                            join y in db.ProduktIntäktsbudget on x.ProduktID equals y.Produkt_ProduktID
                            join p in db.Intäktsbudget on y.Intäktsbudget_IntäktsbudgetID equals p.IntäktsbudgetID
                            select new ProduktSummeringDTO { Budget = p.Budget };

                return query.ToList();
            }
        }

        public List<ProduktSummeringDTO> GetAvdelningIntäkter(AvdelningDTO avdelningDTO) //Sätter ihop Avdelningslistan med Intäktslistan
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt
                            where x.Avdelning_AvdelningID == avdelningDTO.AvdelningsID
                            join y in db.ProduktIntäktsbudget on x.ProduktID equals y.Produkt_ProduktID
                            join p in db.Intäktsbudget on y.Intäktsbudget_IntäktsbudgetID equals p.IntäktsbudgetID
                            select new ProduktSummeringDTO { Budget = p.Budget };

                return query.ToList();
            }   
        }

        public List<ProduktSummeringDTO> GetKontorIntäkter() //Hämtar kontointäkter.
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Intäktsbudget
                            select new ProduktSummeringDTO { Budget = x.Budget };

                return query.ToList();
            }
        }

        public decimal GetProduktKostnader(string produkt) 
        {
            using (var db = new DataContext())
            {
                totaltillverkningskostnad = 0;
                sistaberäknadschablon = 0;
                lön = 0;
                andel = 0;
                lönresultat = 0;
               // beräknadschablon = 0;
                totalandel = 0;
                kostnader = 0;
                pålägg = 0;
                produkten = (from x in db.Produkt
                             where x.ProduktID == produkt
                             select x).FirstOrDefault();

                //beräknadschablon = (BeräknaSchablon() / BeräknaÅrsarbetare());

                decimal årsarbetare = 0;
                decimal beräknadschablon = 0;

                personalkostnad = from x in db.PersonalProdukt
                                  join y in db.Personal on x.Personal_PersonalID equals y.PersonalID
                                  where x.Produkt_ProduktID == produkten.ProduktID
                                  select x;

                foreach (var person in personalkostnad)
                {
                    Console.WriteLine(person.Personal.Namn + "|" + person.Personal.Månadslön + "|" + person.Personal.Årsarbete);
                    Console.WriteLine(person.Placeringsandel);
                }
                    

                foreach (var item in personalkostnad)
                {
                    lön += (item.Personal.Månadslön * (item.Placeringsandel / 100));
                    årsarbetare += (item.Placeringsandel / 100);
                }

                if (årsarbetare != 0)
                {
                    beräknadschablon = BeräknaSchablon() / årsarbetare;
                }

                kostnader = (int)lön + beräknadschablon + GetDirektKostnaderProdukt(produkt);

                decimal tb = BeräknaTB();

                if (kostnader == 0)
                {
                    return 0;
                }
                pålägg = (tb + HämtaAvkastning()) / kostnader;

                kostnader = kostnader + pålägg;

                return kostnader;
                //foreach (var item in personalkostnad)               ////SE ÖVER///////////////////////////////////////////////////////////////////////////////////
                //{
                //    lön = item.Personal.Månadslön;
                //    andel = item.Placeringsandel;                   ////SE ÖVER///////////////////////////////////////////////////////////////////////////////////
                //    andel = (decimal)andel / 100;
                //    lönresultat += lön * andel;                     ////SE ÖVER///////////////////////////////////////////////////////////////////////////////////
                //    totalandel += andel;

                //    var currentSchablon = (from x in db.schablonkostnad
                //                           where x.Konto.Benämning == 5021.ToString()
                //                           select x).FirstOrDefault();

                //        if (currentSchablon != null)
                //    {
                //        var newschablon = new schablonkostnad { Belopp = lönresultat, Konto = currentSchablon.Konto, Konto_KontoID = currentSchablon.Konto_KontoID };
                //        Console.WriteLine("NYtill5021 " + newschablon + "  " + produkten.Namn);
                //        db.schablonkostnad.Remove(currentSchablon);
                //        db.schablonkostnad.Add(newschablon);
                //        db.SaveChanges();
                //    }

                //}

                

                ////if (totalandel != 0)
                ////{
                ////    beräknadschablon = beräknadschablon * totalandel; //vad händer här egentligen? *********************************************************
                ////}

                ////if (totalandel != 0)
                ////{
                ////    beräknadschablon = (BeräknaSchablon() / totalandel);
                ////    sistaberäknadschablon = (beräknadschablon / BeräknaÅrsarbetare());
                ////}

                //kostnader = lönresultat + sistaberäknadschablon; ;


                //kostnader += GetDirektKostnaderProdukt(produkten.ProduktID);


                //if (kostnader != 0)
                //{
                //    pålägg = (BeräknaTB() / kostnader);
                //}


                //var totalkostnad = kostnader + pålägg;
                ////Console.WriteLine("________________");
                ////Console.WriteLine("produkten: " + produkten.Namn + "***");
                ////Console.WriteLine("lönekostnader: " + lönresultat);
                ////Console.WriteLine("schablon: " + sistaberäknadschablon);
                ////Console.WriteLine("totaltk " + kostnader + "*");
                ////Console.WriteLine("pålägg: " + pålägg + "****");
                ////Console.WriteLine("totalkostnad: " + totalkostnad + "***");
                ////Console.WriteLine("________________");

                //return totalkostnad;



            }
        }

        private decimal HämtaAvkastning()
        {
            using (var db = new DataContext())
            {
                avkastningskrav = (from x in db.schablonkostnad
                                   where x.Konto.konto1 == 9999
                                   select x.Belopp).FirstOrDefault();

                return avkastningskrav;
            }
        }

        public decimal GetProduktKostnaderAvdelning(int avdelningID)
        {
            using (var db = new DataContext())
            {
                decimal kostnader = 0;
                var query = from x in db.Produkt
                            where x.Avdelning.AvdelningID == avdelningID
                            select x;

                foreach(var produkt in query)
                {
                    kostnader += GetProduktKostnader(produkt.ProduktID);
                }

                var tb = BeräknaTB();

                if (kostnader != 0)
                {
                    pålägg = tb / kostnader;
                }

                var resultat = kostnader * pålägg;

                return kostnader + resultat;
            } 
        }
        public decimal GetDirektKostnaderProdukt(string produkten)
        {
            noll = 0;
            resultat = 0;
            using (var db = new DataContext())
            {
                dkprodukter = from x in db.DirektkostnadProdukt
                            where x.Produkt_ProduktID == produkten
                            select x;
                foreach (var item in dkprodukter)
                {
                    resultat += item.Belopp;
                }
                if (resultat != 0)
                {
                    return resultat;
                }
                else
                {
                    return noll;
                }
            }
        }
        public decimal BeräknaTB()
        {
            säljavd = 0;
            adminavd = 0;
            direktkostnadersälj = 0;
            direktkostnaderadmin = 0;

            using (var db = new DataContext())
            {
                querysälj = from x in db.Personal
                                join y in db.AvdelningPersonalxRef on x.PersonalID equals y.Personal_PersonalID
                                where y.Avdelning_AvdelningID == 2
                                select y;
                if (querysälj.Count() != 0)
                {
                    foreach(var item in querysälj)
                    {
                        säljavd += item.Personal.Månadslön * ((decimal)item.Placering / 100);
                    }
                }

                queryadmin = from x in db.AvdelningPersonalxRef
                                 join y in db.Personal on x.Personal_PersonalID equals y.PersonalID
                                 where x.Avdelning_AvdelningID == 3
                                 select x;
                if (queryadmin.Count() != 0)
                {
                    foreach(var item in queryadmin)
                    {
                        adminavd += item.Personal.Månadslön * ((decimal)item.Placering / 100);
                    }
                }

                querykostnadsälj= from x in db.DirektkostnadAktivitet
                                      join y in db.Aktivitet on x.Aktivitet_AktivitetID equals y.AktivitetID
                                  where y.Avdelning_AvdelningID == 2
                                  select x;
                foreach (var item in querykostnadsälj)
                {
                    direktkostnadersälj += item.Belopp;
                }
                querykostnadadmin = from x in db.DirektkostnadAktivitet
                                        join y in db.Aktivitet on x.Aktivitet_AktivitetID equals y.AktivitetID
                                       where y.Avdelning_AvdelningID == 3
                                       select x;
                foreach (var item in querykostnadadmin)
                {
                    direktkostnaderadmin += item.Belopp;
                }

                //avkastningskrav = (from x in db.schablonkostnad
                //                       where x.Konto.konto1 == 9999
                //                    select x.Belopp).FirstOrDefault();

                //Console.WriteLine("säljavd " + säljavd + " adminavd " + adminavd + " direktkostnadsälj " + direktkostnadersälj + " direktkostadmin " + direktkostnaderadmin + " avkastningskrav" + avkastningskrav);

                decimal tb;
                return tb = (säljavd + direktkostnadersälj) + (adminavd + direktkostnaderadmin);


            }
                
        }
        public decimal BeräknaSchablon()
        {
            using (var db = new DataContext())
            {
                decimal sum = 0;

                var konton = from x in db.schablonkostnad
                             orderby x.Konto.konto1
                             select x;
                foreach (var item in konton)
                {
                    if (item.Konto.konto1 != 9999 && item.Konto.konto1 != 5021)
                    {
                        sum += item.Belopp;
                    }
                }

                return sum;
                //schablonresultat = (from x in db.schablonkostnad
                //                    where x.Konto.konto1 != 5021
                //                    select x.Belopp).Sum();


                //return schablonresultat;
            }
        }
        public decimal BeräknaÅrsarbetare()
        {
            using (var db = new DataContext())
            {
                årsarbeteresultat = (from x in db.Personal
                                select x.Årsarbete).Sum() / 100;

                return årsarbeteresultat;
            }
        }

        public List<string> FörberedaExportProduktDTO(List<string> ProduktDTOer)    //Förebereder Export av ProduktDTOer
        {
            List<string> FörberedaProduktDTOer = new List<string>();

            foreach (var item in ProduktDTOer)
            {
                FörberedaProduktDTOer.Add(item);
            }

            return FörberedaProduktDTOer;
        }

        //public void GetAllBudgeteratResultatExport()
        //{
        //    ProduktRepository instans = new ProduktRepository();
        //    instans.GetAllProdukter();

        //    List<string> budreslist = new List<string>();
        //    //budreslist.Add(instans.GetAllProdukter().ToString());

            
        //    var produkt = instans.GetProduktByNamn("gasell");

        //    budreslist.Add(GetProduktIntäkter(produkt).ToString());


        //}
    }
}
