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
        public List<ProduktSummeringDTO> GetProduktIntäkter(ProduktDTO produkt)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.ProduktIntäktsbudget.AsParallel()
                            where x.Produkt_ProduktID == produkt.ProduktID
                            join y in db.Intäktsbudget.AsParallel() on x.Intäktsbudget_IntäktsbudgetID equals y.IntäktsbudgetID
                            select new ProduktSummeringDTO { Budget = y.Budget };

                return query.ToList();
            }
        }

        public List<ProduktSummeringDTO> GetGruppIntäkter(ProduktgruppDTO produktgruppDTO)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt.AsParallel()
                            where x.Produktgrupp_ProduktgruppID == produktgruppDTO.ProduktgruppID
                            join y in db.ProduktIntäktsbudget.AsParallel() on x.ProduktID equals y.Produkt_ProduktID
                            join p in db.Intäktsbudget.AsParallel() on y.Intäktsbudget_IntäktsbudgetID equals p.IntäktsbudgetID
                            select new ProduktSummeringDTO { Budget = p.Budget };

                return query.ToList();
            }
        }

        public List<ProduktSummeringDTO> GetAvdelningIntäkter(AvdelningDTO avdelningDTO)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt.AsParallel()
                            where x.Avdelning_AvdelningID == avdelningDTO.AvdelningsID
                            join y in db.ProduktIntäktsbudget.AsParallel() on x.ProduktID equals y.Produkt_ProduktID
                            join p in db.Intäktsbudget.AsParallel() on y.Intäktsbudget_IntäktsbudgetID equals p.IntäktsbudgetID
                            select new ProduktSummeringDTO { Budget = p.Budget };

                return query.ToList();
            }   
        }

        public List<ProduktSummeringDTO> GetKontorIntäkter()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Intäktsbudget.AsParallel()
                            select new ProduktSummeringDTO { Budget = x.Budget };

                return query.ToList();
            }
        }

        public decimal GetProduktKostnader(string produkt)
        {
            using (var db = new DataContext())
            {
                decimal lön = 0;
                decimal andel = 0;
                decimal lönresultat = 0;
                decimal beräknadschablon = 0;
                decimal totalandel = 0;
                decimal kostnader = 0;
                decimal pålägg = 0;
                var produkten = (from x in db.Produkt.AsParallel()
                                 where x.ProduktID == produkt
                                 select x).FirstOrDefault();

                beräknadschablon = (BeräknaSchablon() / BeräknaÅrsarbetare());

                var personalkostnad = from x in db.PersonalProdukt.AsParallel()
                                      join y in db.Personal.AsParallel() on x.Personal_PersonalID equals y.PersonalID
                                      where x.Produkt_ProduktID == produkten.ProduktID
                                      select x;

                Parallel.ForEach(personalkostnad, (item) =>
                {
                    lön = item.Personal.Månadslön;
                    andel = item.Placeringsandel;
                    andel = (decimal)andel / 100;
                    lönresultat += lön * andel;
                    totalandel += andel;
                });

                if (totalandel != 0)
                {
                    beräknadschablon = beräknadschablon * totalandel;
                }
               
                kostnader = lönresultat + beräknadschablon;

                kostnader += GetDirektKostnaderProdukt(produkten.ProduktID);

                if (kostnader != 0)
                {
                    pålägg = BeräknaTB(produkten) / kostnader;
                }

                var resultat = kostnader * pålägg;

                return kostnader + resultat;
            }
        }
        public decimal GetDirektKostnaderProdukt(string produkten)
        {
            decimal noll = 0;
            decimal resultat = 0;
            using (var db = new DataContext())
            {
                var query = from x in db.DirektkostnadProdukt
                            where x.Produkt_ProduktID == produkten
                            select x;
                foreach (var item in query)
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
        public decimal BeräknaTB(Produkt produkt)
        {
            decimal säljavd = 0;
            decimal adminavd = 0;
            decimal direktkostnadersälj = 0;
            decimal direktkostnaderadmin = 0;

            using (var db = new DataContext())
            {
                var querysälj = from x in db.Personal.AsParallel()
                                join y in db.AvdelningPersonalxRef.AsParallel() on x.PersonalID equals y.Personal_PersonalID
                                where y.Avdelning_AvdelningID == 2
                                select y;
                if (querysälj.Count() != 0)
                {
                    Parallel.ForEach(querysälj, (item) =>
                    {
                        säljavd += item.Personal.Månadslön * ((decimal)item.Placering / 100);
                    });
                }
                var queryadmin = from x in db.AvdelningPersonalxRef.AsParallel()
                                 join y in db.Personal.AsParallel() on x.Personal_PersonalID equals y.PersonalID
                                 where x.Avdelning_AvdelningID == 3
                                 select x;
                if (queryadmin.Count() != 0)
                {
                    Parallel.ForEach(queryadmin, (item) =>
                    {
                        adminavd += item.Personal.Månadslön * ((decimal)item.Placering / 100);
                    });
                }

                var querykostnadsälj= from x in db.DirektkostnadAktivitet.AsParallel()
                                      join y in db.Aktivitet.AsParallel() on x.Aktivitet_AktivitetID equals y.AktivitetID
                                  where y.Avdelning_AvdelningID == 2
                                  select x;
                if (querykostnadsälj.Count() != 0)
                {
                    direktkostnadersälj = querykostnadsälj.Sum(x => x.Belopp);
                }

                var querykostnadadmin = from x in db.DirektkostnadAktivitet.AsParallel()
                                        join y in db.Aktivitet.AsParallel() on x.Aktivitet_AktivitetID equals y.AktivitetID
                                       where y.Avdelning_AvdelningID == 3
                                       select x;
                if (querykostnadadmin.Count() != 0)
                {
                    direktkostnaderadmin = querykostnadadmin.Sum(x => x.Belopp);
                }

                var avkastningskrav = (from x in db.schablonkostnad
                                       where x.Konto.konto1 == 9999
                                    select x.Belopp).FirstOrDefault();

                return (säljavd + adminavd + direktkostnadersälj + direktkostnaderadmin+ avkastningskrav);

            }
                
        }
        public decimal BeräknaSchablon()
        {
            using (var db = new DataContext())
            {
                var schablonskonstnad = from x in db.schablonkostnad
                                        where x.Konto.konto1 > 5021 & x.Konto.konto1 < 8572
                                        select x;
                var schablonresultat = schablonskonstnad.Sum(x => x.Belopp);

                return schablonresultat;
            }
        }
        public decimal BeräknaÅrsarbetare()
        {
            using (var db = new DataContext())
            {
                var årsarbete = from x in db.Personal
                                select x;
                var årsarbeteresultat = årsarbete.Sum(x => x.Årsarbete) / 100;

                return årsarbeteresultat;
            }
        }
    }
}
