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

        public void AddKundProdukt(ProduktDTO produkt, decimal avtal, decimal tillägg, bool gradT, bool gradA, decimal budget, int tim, string kommentar, string kundId)
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
                intäktsbudget.Budget = budget;
                intäktsbudget.Tim = tim;
                intäktsbudget.KundIntäktsbudget.Add(kundIntäktsbudget);
                intäktsbudget.Kommentar = kommentar;
                intäktsbudget.Låst = false;

                db.Intäktsbudget.Add(intäktsbudget);
                db.SaveChanges();
            }
        }

        public void RemoveKundProdukt(IntäktsbudgetKundDTO produkten)
        {
            using (var db = new DataContext())
            {
                var produktbudget = db.ProduktIntäktsbudget.Where(x => x.Produkt_ProduktID == produkten.ProduktID).FirstOrDefault();
                var intäksbudget = db.Intäktsbudget.Where(x => x.IntäktsbudgetID == produktbudget.Intäktsbudget_IntäktsbudgetID).FirstOrDefault();
                var kundbudget = db.KundIntäktsbudget.Where(x => x.Intäktsbudget_IntäktsbudgetID == intäksbudget.IntäktsbudgetID).FirstOrDefault();

                db.KundIntäktsbudget.Remove(kundbudget);
                db.Intäktsbudget.Remove(intäksbudget);
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
    }
}
