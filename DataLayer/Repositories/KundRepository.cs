using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class KundRepository
    {

        public List<KundDTO> GetKunderByID(int id) 
        { 
            using (var db = new DataContext())
            {
                var query = from x in db.Kund
                            where x.KundID == id
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori.Namn };

                return query.ToList();
            }
        }
        public List<KundDTO> GetKunderByNamn(string namn)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Kund
                            where x.Namn == namn
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori.Namn };

                return query.ToList();
            }
        }
        public List<KundDTO> GetKunderByKategori(string kategori)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Kund
                            where x.KundKategori.ToString() == kategori
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori.Namn };

                return query.ToList();
            }
        }
        public List<KundDTO> GetAllKunder()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Kund
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori.Namn };

                return query.ToList();
            }                
        }

        public void AddKund(int id, string namn, string kategori)
        {
            using (var db = new DataContext())
            {
                var kundKategori = (from x in db.KundKategori
                                    where x.Namn == kategori
                                    select x).FirstOrDefault();

                var kund = new Kund {KundID = id, Namn = namn, KundKategori = kundKategori };
                db.Kund.Add(kund);

                db.SaveChanges();
            }
        }
    }
}
