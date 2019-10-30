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
        public List<IntäktsbudgetKundDTO> GetAllKundProdukter(string kundID)
        {
            using (var db = new DataContext())
            {
                var kund = db.Kund.Where(x => x.KundID == kundID).FirstOrDefault();
                var kunden = db.KundIntäktsbudget.Where(x => x.Kund_KundID == kund.KundID).FirstOrDefault();

                var intäkt = from x in db.Intäktsbudget
                             where x.IntäktsbudgetID == kunden.Intäktsbudget_IntäktsbudgetID
                             select new IntäktsbudgetKundDTO { Avtal = x.Avtal, GradA = x.GradA, GradT = x.GradT, Kommentar = x.Kommentar, Tillägg = x.Tillägg, Tim = x.Tim, Budget = x.Budget, };
                return intäkt.ToList();
            }
        }

        public void AddKundProdukt(ProduktDTO produkt, decimal avtal, decimal tillägg, bool gradT, bool gradA, decimal budget, int tim, string kommentar, string kundId)
        {
            using (var db = new DataContext())
            {
                Intäktsbudget intäktsbudget = new Intäktsbudget();
                ProduktIntäktsbudget produktIntäktsbudget = new ProduktIntäktsbudget();
                produktIntäktsbudget.Produkt_ProduktID = produkt.ProduktID;
                KundIntäktsbudget kundIntäktsbudget = new KundIntäktsbudget();
                kundIntäktsbudget.Kund_KundID = kundId;

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
                //var omvandling = db.Produkt.Where(x => x.ProduktID == produkten.ProduktID).FirstOrDefault();
                //var produkt = db.Intäktsbudget.Where(x => x.IntäktsbudgetID == omvandling.).FirstOrDefault();

                //db.Intäktsbudget.Remove(produkt);
                //db.SaveChanges();
            }
        }

        public void CreateIntäktsBudget(string kundID)
        {
            using (var db = new DataContext())
            {
                Intäktsbudget intäkts = new Intäktsbudget();
                db.Intäktsbudget.Add(intäkts);

                var kundIntäkt = new KundIntäktsbudget { Kund_KundID = kundID, Intäktsbudget = intäkts };
                db.KundIntäktsbudget.Add(kundIntäkt);
                
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
