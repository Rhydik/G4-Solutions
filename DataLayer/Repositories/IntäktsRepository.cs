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
                var produkten = db.Produkt.Where(x => x.Intäktsbudget.Kund_KundID == kundID).FirstOrDefault();
                var intäkt = from x in db.Produkt
                             where x.Intäktsbudget.Kund_KundID == kundID
                             select new IntäktsbudgetKundDTO { Avtal = x.Intäktsbudget.Avtal, GradA = x.Intäktsbudget.GradA, GradT = x.Intäktsbudget.GradT, Kommentar = x.Intäktsbudget.Kommentar, Tillägg = x.Intäktsbudget.Tillägg, Tim = x.Intäktsbudget.Tim, Budget = x.Intäktsbudget.Budget, ProduktID = x.ProduktID, ProduktNamn = x.Namn };
                return intäkt.ToList();
            }
        }

        public void AddKundProdukt(ProduktDTO produkt, decimal avtal, decimal tillägg, bool gradT, bool gradA, decimal budget, int tim, string kommentar, string kundId)
        {
            using (var db = new DataContext())
            {
                Intäktsbudget intäktsbudget = new Intäktsbudget();

                var produkten = db.Produkt.Where(x => x.ProduktID == produkt.ProduktID).FirstOrDefault();

                intäktsbudget.Produkt.Add(produkten);
                intäktsbudget.Avtal = avtal;
                intäktsbudget.Tillägg = tillägg;
                intäktsbudget.GradT = gradT;
                intäktsbudget.GradA = gradA;
                intäktsbudget.Budget = budget;
                intäktsbudget.Tim = tim;
                intäktsbudget.Kund_KundID = kundId;
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
                var omvandling = db.Produkt.Where(x => x.ProduktID == produkten.ProduktID).FirstOrDefault();
                var produkt = db.Intäktsbudget.Where(x => x.IntäktsbudgetID == omvandling.Intäktsbudget_IntäktsbudgetID).FirstOrDefault();

                db.Intäktsbudget.Remove(produkt);
                db.SaveChanges();
            }
        }
    }
}
