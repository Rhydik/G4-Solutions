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
                var intäkt = from x in db.Intäktsbudget
                              where x.Kund_KundID == kundID
                              select new IntäktsbudgetKundDTO { Avtal = x.Avtal, GradA = x.GradA, GradT = x.GradT, Kommentar = x.Kommentar, Tillägg = x.Tillägg, Tim = x.Tim, };
                return intäkt.ToList();
            }
        }
    }
}
