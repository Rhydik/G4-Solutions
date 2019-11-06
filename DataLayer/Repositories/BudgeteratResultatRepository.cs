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
                var query = from x in db.ProduktIntäktsbudget
                            where x.Produkt_ProduktID == produkt.ProduktID
                            join y in db.Intäktsbudget on x.Intäktsbudget_IntäktsbudgetID equals y.IntäktsbudgetID
                            select new ProduktSummeringDTO { Budget = y.Budget };

                return query.ToList();
            }
        }

        public List<ProduktSummeringDTO> GetGruppIntäkter(ProduktgruppDTO produktgruppDTO)
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

        public List<ProduktSummeringDTO> GetAvdelningIntäkter(AvdelningDTO avdelningDTO)
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

        public List<ProduktSummeringDTO> GetKontorIntäkter()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Intäktsbudget
                            select new ProduktSummeringDTO { Budget = x.Budget };

                return query.ToList();
            }
        }
    }
}
