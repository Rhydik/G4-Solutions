using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProduktRepository
    {
        public List<ProduktDTO> GetAllProdukter()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt
                            select new ProduktDTO {ProduktID = x.ProduktID, Namn = x.Namn, Produktgrupp = x.Produktgrupp, ProduktKategori = x.Produktkategori};

                return query.ToList();
            }
        }

        public void AddProdukt()
        {
                using (var db = new DataContext())
                {
                    var namn = "produkttest2000";
                    var produkt = new Produkt {Namn = namn,};
               
                    db.Produkt.Add(produkt);
                    db.SaveChanges();

                }
        }

    }
}
