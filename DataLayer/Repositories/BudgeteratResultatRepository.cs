using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DTO;


namespace DataLayer
{
    public class BudgeteratResultatRepository
    {
        double totaltillverkningskostnad;
        double sistaberäknadschablon;
        double lön;
        double andel;
        double lönresultat;
        private IQueryable<PersonalProdukt> personalkostnad;
        double totalandel;
        double kostnader;
        double totalkostnad;
        double pålägg;
        private Produkt produkten;
        double noll;
        double resultat;
        double säljavd;
        double adminavd;
        double direktkostnadersälj;
        double direktkostnaderadmin;
        private IQueryable<Personal> årsarbete;
        private IQueryable<Personal> till5021;
        private double årsarbeteresultat;
        private IQueryable<schablonkostnad> schablonskonstnad;
        private double schablonresultat;
        private double avkastningskrav;
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

        public double GetProduktKostnaderPre(string produkt)
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

                double årsarbetare = 0;
                double beräknadschablon = 0;

                personalkostnad = from x in db.PersonalProdukt
                                  join y in db.Personal on x.Personal_PersonalID equals y.PersonalID
                                  where x.Produkt_ProduktID == produkten.ProduktID
                                  select x;

                foreach (var item in personalkostnad)
                {
                    lön += (double)(item.Personal.Månadslön * (item.Placeringsandel / 100));
                    årsarbetare += (double)(item.Placeringsandel / 100);
                }


                if (årsarbetare != 0)
                {
                    beräknadschablon = BeräknaSchablon() * årsarbetare;
                }

                kostnader = lön + beräknadschablon + GetDirektKostnaderProdukt(produkt);

                return kostnader;
            }
        }

        public double GetProduktKostnader(string produkt)
        {
            var kostnad = GetProduktKostnaderPre(produkt);


            if (kostnad == 0)
            {
                return 0;
            }

            pålägg = GetPålägg();

            return kostnad + (kostnad * pålägg);
        }

        private double GetPålägg()
        {
            double total = 0;
            using (var db = new DataContext())
            {

                var prod = from x in db.Produkt
                           select x;

                foreach (var item in prod)
                {
                    total += GetProduktKostnaderPre(item.ProduktID);
                }
            }

            var tb = BeräknaTB() + HämtaAvkastning();

            var resultat = tb / total;

            return resultat;
        }

        private double HämtaAvkastning()
        {
            using (var db = new DataContext())
            {
                avkastningskrav = (double)(from x in db.schablonkostnad
                                           where x.Konto.konto1 == 9999
                                           select x.Belopp).FirstOrDefault();

                return avkastningskrav;
            }
        }

        public double GetProduktKostnaderAvdelning(int avdelningID)
        {
            using (var db = new DataContext())
            {
                double kostnader = 0;
                var query = from x in db.Produkt
                            where x.Avdelning.AvdelningID == avdelningID
                            select x;

                foreach (var produkt in query)
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
        public double GetDirektKostnaderProdukt(string produkten)
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
                    resultat += (double)item.Belopp;
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
        public double BeräknaTB()
        {
            säljavd = 0;
            adminavd = 0;
            direktkostnadersälj = 0;
            direktkostnaderadmin = 0;

            using (var db = new DataContext())
            {
                querysälj = from x in db.Personal
                            join y in db.AvdelningPersonalxRef on x.PersonalID equals y.Personal_PersonalID
                            where y.Avdelning_AvdelningID == 2 && y.Placering > 0
                            select y;
                if (querysälj.Count() != 0)
                {
                    foreach (var item in querysälj)
                    {
                        säljavd += (item.Personal.Månadslön * (item.Placering / 100));
                    }
                }

                queryadmin = from x in db.AvdelningPersonalxRef
                             join y in db.Personal on x.Personal_PersonalID equals y.PersonalID
                             where x.Avdelning_AvdelningID == 3 && x.Placering > 0
                             select x;
                if (queryadmin.Count() != 0)
                {
                    foreach (var item in queryadmin)
                    {
                        adminavd += (double)(item.Personal.Månadslön * (item.Placering / 100));
                    }
                }

                querykostnadsälj = from x in db.DirektkostnadAktivitet
                                   join y in db.Aktivitet on x.Aktivitet_AktivitetID equals y.AktivitetID
                                   where y.Avdelning_AvdelningID == 2
                                   select x;
                foreach (var item in querykostnadsälj)
                {
                    direktkostnadersälj += (double)item.Belopp;
                }
                querykostnadadmin = from x in db.DirektkostnadAktivitet
                                    join y in db.Aktivitet on x.Aktivitet_AktivitetID equals y.AktivitetID
                                    where y.Avdelning_AvdelningID == 3
                                    select x;
                foreach (var item in querykostnadadmin)
                {
                    direktkostnaderadmin += (double)item.Belopp;
                }

                return (säljavd + direktkostnadersälj) + (adminavd + direktkostnaderadmin);
            }

        }
        public double BeräknaSchablon()
        {
            using (var db = new DataContext())
            {
                double totalÅrsarbete = 0;
                double totalSchablon = 0;
                var konton = from x in db.schablonkostnad
                             orderby x.Konto.konto1
                             select x;

                var totalÅrsarbetare = from x in db.PersonalProdukt
                                       join y in db.Personal on x.Personal_PersonalID equals y.PersonalID
                                       where x.Placeringsandel > 0
                                       select x;

                foreach (var item in totalÅrsarbetare)
                {
                    totalÅrsarbete += (item.Placeringsandel / 100);
                }
                totalSchablon = Enumerable.Sum(konton.Where(item => item.Konto.konto1 != 9999 && item.Konto.konto1 != 5021), item => (double)item.Belopp);

                return totalSchablon / totalÅrsarbete;
            }
        }
        public double BeräknaÅrsarbetare()
        {
            using (var db = new DataContext())
            {
                årsarbeteresultat = (double)((from x in db.Personal
                                              select x.Årsarbete).Sum() / 100);

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
    }
}
