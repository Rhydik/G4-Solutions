using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DTO;

namespace DataLayer
{
    public class IntäktsRepository
    {
        public List<IntäktsbudgetKundDTO> GetAllKundProdukter(string kundId)
        {
            using (var db = new DataContext())
            {
                var kund = db.Kund.Where(x => x.KundID == kundId).FirstOrDefault();
                var kunden = db.KundIntäktsbudget.Where(x => x.Kund_KundID == kund.KundID).FirstOrDefault();
               
                if (kunden != null)
                {
                    var intäkt = from x in db.KundIntäktsbudget
                                 where x.Kund_KundID == kundId
                                 join y in db.Intäktsbudget on x.Intäktsbudget_IntäktsbudgetID equals y.IntäktsbudgetID
                                 join prod in db.ProduktIntäktsbudget on y.IntäktsbudgetID equals prod.Intäktsbudget_IntäktsbudgetID
                                 join prodnamn in db.Produkt on prod.Produkt_ProduktID equals prodnamn.ProduktID
                                 select new IntäktsbudgetKundDTO { Avtal = y.Avtal, GradA = y.GradA, GradT = y.GradT, Kommentar = y.Kommentar, Tillägg = y.Tillägg, Tim = y.Tim, Budget = y.Budget, ProduktID = prod.Produkt_ProduktID, ProduktNamn = prodnamn.Namn };
                    return intäkt.ToList();
                }
                else
                {
                    return new List<IntäktsbudgetKundDTO>();
                }
            }
        }

        public void AddKundProdukt(ProduktDTO produkt, decimal avtal, decimal tillägg, bool gradT, bool gradA, int tim, string kommentar, string kundId)
        {
            using (var db = new DataContext())
            {
                Intäktsbudget intäktsbudget = new Intäktsbudget();
                ProduktIntäktsbudget produktIntäktsbudget = new ProduktIntäktsbudget() { Intäktsbudget = intäktsbudget, Intäktsbudget_IntäktsbudgetID = intäktsbudget.IntäktsbudgetID, Produkt_ProduktID = produkt.ProduktID };
                KundIntäktsbudget kundIntäktsbudget = new KundIntäktsbudget() { Intäktsbudget = intäktsbudget, Kund_KundID = kundId, Intäktsbudget_IntäktsbudgetID = intäktsbudget.IntäktsbudgetID };
                

                intäktsbudget.ProduktIntäktsbudget.Add(produktIntäktsbudget);
                intäktsbudget.Avtal = avtal;
                intäktsbudget.Tillägg = tillägg;
                intäktsbudget.GradT = gradT;
                intäktsbudget.GradA = gradA;
                intäktsbudget.Budget = avtal + tillägg;
                intäktsbudget.Tim = tim;
                intäktsbudget.KundIntäktsbudget.Add(kundIntäktsbudget);
                intäktsbudget.Kommentar = kommentar;
                intäktsbudget.Låst = false;

                db.Intäktsbudget.Add(intäktsbudget);

                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }

        public List<IntäktsbudgetProduktDTO> GetAllProduktKunder(string produktId)
        {
            using (var db = new DataContext())
            {
                var produkt = db.Produkt.Where(x => x.ProduktID == produktId).FirstOrDefault();
                var produkten = db.ProduktIntäktsbudget.Where(x => x.Produkt_ProduktID == produkt.ProduktID).FirstOrDefault();

                if (produkten != null)
                {
                    var intäkt = from x in db.ProduktIntäktsbudget
                                 where x.Produkt_ProduktID == produktId
                                 join y in db.Intäktsbudget on x.Intäktsbudget_IntäktsbudgetID equals y.IntäktsbudgetID
                                 join kun in db.KundIntäktsbudget on y.IntäktsbudgetID equals kun.Intäktsbudget_IntäktsbudgetID
                                 join kunNamn in db.Kund on kun.Kund_KundID equals kunNamn.KundID
                                 select new IntäktsbudgetProduktDTO { Avtal = y.Avtal, GradA = y.GradA, GradT = y.GradT, Kommentar = y.Kommentar, Tillägg = y.Tillägg, Tim = y.Tim, Budget = y.Budget, KundID = kun.Kund_KundID, KundNamn = kunNamn.Namn };
                    return intäkt.ToList();
                }
                else
                {
                    return new List<IntäktsbudgetProduktDTO>();
                }
            }
        }

        public void AddProduktKund(KundDTO kund, decimal avtal, decimal tillägg, bool gradT, bool gradA, int tim, string kommentar, string produktID)
        {
            using (var db = new DataContext())
            {
                Intäktsbudget intäktsbudget = new Intäktsbudget();
                ProduktIntäktsbudget produktIntäktsbudget = new ProduktIntäktsbudget() { Intäktsbudget = intäktsbudget, Intäktsbudget_IntäktsbudgetID = intäktsbudget.IntäktsbudgetID, Produkt_ProduktID = produktID };
                KundIntäktsbudget kundIntäktsbudget = new KundIntäktsbudget() { Intäktsbudget = intäktsbudget, Kund_KundID = kund.KundID, Intäktsbudget_IntäktsbudgetID = intäktsbudget.IntäktsbudgetID };


                intäktsbudget.ProduktIntäktsbudget.Add(produktIntäktsbudget);
                intäktsbudget.Avtal = avtal;
                intäktsbudget.Tillägg = tillägg;
                intäktsbudget.GradT = gradT;
                intäktsbudget.GradA = gradA;
                intäktsbudget.Budget = avtal + tillägg;
                intäktsbudget.Tim = tim;
                intäktsbudget.KundIntäktsbudget.Add(kundIntäktsbudget);
                intäktsbudget.Kommentar = kommentar;
                intäktsbudget.Låst = false;

                db.Intäktsbudget.Add(intäktsbudget);
                db.SaveChanges();
            }

        }

        public void RemoveKundProdukt(IntäktsbudgetKundDTO produkten, string kundId)
        {
            using (var db = new DataContext())
            {
                var kundbudget = (from x in db.KundIntäktsbudget
                                  where x.Kund_KundID == kundId
                                  select x).FirstOrDefault();

                var produktbudget = (from x in db.ProduktIntäktsbudget
                                     where x.Produkt_ProduktID == produkten.ProduktID
                                     select x).FirstOrDefault();

                var intäktsbudget = (from x in db.KundIntäktsbudget
                             where x.Kund_KundID == kundId
                             join y in db.Intäktsbudget on x.Intäktsbudget_IntäktsbudgetID equals y.IntäktsbudgetID
                             select y).FirstOrDefault();

                db.ProduktIntäktsbudget.Remove(produktbudget);
                db.KundIntäktsbudget.Remove(kundbudget);
                db.Intäktsbudget.Remove(intäktsbudget); 
                
                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }

        public void RemoveProduktKund(IntäktsbudgetProduktDTO kunden, string produktID)
        {
            using (var db = new DataContext())
            {
                var kundbudget = (from x in db.KundIntäktsbudget
                                  where x.Kund_KundID == kunden.KundID
                                  select x).FirstOrDefault();

                var produktbudget = (from x in db.ProduktIntäktsbudget
                                     where x.Produkt_ProduktID == produktID
                                     select x).FirstOrDefault();

                var intäktsbudget = (from x in db.ProduktIntäktsbudget
                                     where x.Produkt_ProduktID == produktID
                                     join y in db.Intäktsbudget on x.Intäktsbudget_IntäktsbudgetID equals y.IntäktsbudgetID
                                     select y).FirstOrDefault();

                db.ProduktIntäktsbudget.Remove(produktbudget);
                db.KundIntäktsbudget.Remove(kundbudget);
                db.Intäktsbudget.Remove(intäktsbudget);
                db.SaveChanges();
            }
        }

        public List<KundIntäktsbudget> GetAllKundID(string kundid)
        {
            using (var db = new DataContext())
            {
                var intäktsbudget = db.KundIntäktsbudget.Where(x => x.Kund_KundID == kundid);
                return intäktsbudget.ToList();
            }
        }

        public List<ProduktDTO> GetProduktWithoutIntäkt()
        {
            using (var db = new DataContext())
            {
                var test = from p in db.ProduktIntäktsbudget
                           join x in db.Intäktsbudget on p.Intäktsbudget_IntäktsbudgetID equals x.IntäktsbudgetID
                           join prod in db.Produkt on p.Produkt_ProduktID equals prod.ProduktID
                           select new ProduktDTO { ProduktID = prod.ProduktID, Avdelning = prod.Avdelning.Namn, Namn = prod.Namn, Produktgrupp = prod.Produktgrupp.Namn, Produktkategori = prod.Produktkategori.Namn };

                var produkt = from x in db.Produkt
                              select new ProduktDTO { ProduktID = x.ProduktID, Avdelning = x.Avdelning.Namn, Namn = x.Namn, Produktgrupp = x.Produktgrupp.Namn, Produktkategori = x.Produktkategori.Namn };

                var difference = produkt.Where(p => !test.Contains(p));

                return difference.ToList();
            }
        }
    }
}