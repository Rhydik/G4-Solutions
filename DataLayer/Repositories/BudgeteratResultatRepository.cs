using System;
using System.Collections.Generic;
using System.Linq;
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
        decimal beräknadschablon;
        private IQueryable<PersonalProdukt> personalkostnad;
        decimal totalandel;
        decimal kostnader;
        decimal pålägg;
        private Produkt produkten;
        decimal noll;
        decimal resultat;
        decimal säljavd;
        decimal adminavd;
        decimal direktkostnadersälj;
        decimal direktkostnaderadmin;
        private IQueryable<Personal> årsarbete;
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
                beräknadschablon = 0;
                totalandel = 0;
                kostnader = 0;
                pålägg = 0;
                produkten = (from x in db.Produkt
                             where x.ProduktID == produkt
                             select x).FirstOrDefault();

                //beräknadschablon = (BeräknaSchablon() / BeräknaÅrsarbetare());



                personalkostnad = from x in db.PersonalProdukt
                                  join y in db.Personal on x.Personal_PersonalID equals y.PersonalID
                                  where x.Produkt_ProduktID == produkten.ProduktID
                                  select x;

                foreach (var item in personalkostnad)
                {
                    lön = item.Personal.Månadslön;
                    andel = item.Placeringsandel;
                    andel = (decimal)andel / 100;
                    lönresultat += lön * andel;
                    totalandel += andel;
                }

                

                //if (totalandel != 0)
                //{
                //    beräknadschablon = beräknadschablon * totalandel; //vad händer här egentligen? *********************************************************
                //}

                if (totalandel != 0)
                {
                    beräknadschablon = (BeräknaSchablon() / totalandel);
                    sistaberäknadschablon = (beräknadschablon / BeräknaÅrsarbetare());
                }

                kostnader = lönresultat + sistaberäknadschablon; ;


                kostnader += GetDirektKostnaderProdukt(produkten.ProduktID);


                totaltillverkningskostnad = kostnader;


                if (totaltillverkningskostnad != 0)
                {
                    pålägg = (BeräknaTB() / totaltillverkningskostnad);
                }


                var totalkostnad = totaltillverkningskostnad + pålägg;

                Console.WriteLine("*kostnad: " + kostnader + "**");
                Console.WriteLine("totaltk " + totaltillverkningskostnad + "*");
                Console.WriteLine("pålägg: " + pålägg + "****");
                Console.WriteLine("totalkostnad: " + totalkostnad + "***");
                Console.WriteLine("produkten: " + produkten.Namn + "***");

                return kostnader + totalkostnad;



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
                if (querykostnadsälj.Count() != 0)
                {
                    direktkostnadersälj = querykostnadsälj.Sum(x => x.Belopp);
                }

                querykostnadadmin = from x in db.DirektkostnadAktivitet
                                        join y in db.Aktivitet on x.Aktivitet_AktivitetID equals y.AktivitetID
                                       where y.Avdelning_AvdelningID == 3
                                       select x;
                if (querykostnadadmin.Count() != 0)
                {
                    direktkostnaderadmin = querykostnadadmin.Sum(x => x.Belopp);
                }

                avkastningskrav = (from x in db.schablonkostnad
                                       where x.Konto.konto1 == 9999
                                    select x.Belopp).FirstOrDefault();

                Console.WriteLine("säljavd " + säljavd + " adminavd " + adminavd + " direktkostnadsälj " + direktkostnadersälj + " direktkostadmin " + direktkostnaderadmin + " avkastningskrav" + avkastningskrav);

                return (säljavd + adminavd + direktkostnadersälj + direktkostnaderadmin+ avkastningskrav);


            }
                
        }
        public decimal BeräknaSchablon()
        {
            using (var db = new DataContext())
            {
                schablonresultat = (from x in db.schablonkostnad
                                        where x.Konto.konto1 > 5021 & x.Konto.konto1 < 8572
                                        select x.Belopp).Sum();

                return schablonresultat;
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
    }
}
