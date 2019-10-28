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

        public List<KundDTO> GetKunderByID(string id) 
        { 
            using (var db = new DataContext())
            {
                var query = from x in db.Kund
                            where x.KundID.StartsWith(id)
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori.Namn };

                return query.ToList();
            }
        }
        public List<KundDTO> GetKunderByNamn(string namn)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Kund
                            where x.Namn.StartsWith(namn)
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori.Namn };

                return query.ToList();
            }
        }

        public void RemoveKund(string kundId)
        {
            using (var db = new DataContext())
            {
                var kunden = db.Kund.Where(x => x.KundID == kundId).FirstOrDefault();
                db.Kund.Remove(kunden);
                db.SaveChanges();
            }
        }

        public List<KundDTO> GetKunderByKategori(string kategori)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Kund
                            where x.KundKategori.Namn == kategori
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori.Namn };

                return query.ToList();
            }
        }
        public List<KundDTO> GetKunderBySearch(string id, string namn, string kategori)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Kund
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori.Namn };

                if (!string.IsNullOrEmpty(id))
                    query = query.Where(KundDTO => KundDTO.KundID.StartsWith(id));

                //Ändrat så att sökningen inte behöver vara exakt namnet, utan kan börja med det. Fungerar även med korrekta namn ///Leonard
                if (!string.IsNullOrEmpty(namn))
                    query = query.Where(KundDTO => KundDTO.Namn.StartsWith(namn)); 

                if (!string.IsNullOrEmpty(kategori))
                    query = query.Where(KundDTO => KundDTO.KundKategori == kategori);

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

        public void AddKund(string id, string namn, string kategori)
        {
            using (var db = new DataContext())
            {
                var kundKategori = (from x in db.KundKategori
                                    where x.Namn == kategori
                                    select x).FirstOrDefault();

                var kund = new Kund {KundID = id, Namn = namn, KundKategori = kundKategori,};
                db.Kund.Add(kund);

                db.SaveChanges();
            }
        }
        public void UpdateKund(KundDTO oldKund, string id, string namn, string kategori)
        {
            using (var db = new DataContext())
            {
                var kundKategori = (from x in db.KundKategori
                                    where x.Namn == kategori
                                    select x).FirstOrDefault();

                var tempKund = (from x in db.Kund
                               where x.KundID == oldKund.KundID
                               select x).FirstOrDefault();

                var kund = new Kund { KundID = id, Namn = namn, KundKategori = kundKategori };
                db.Kund.Remove(tempKund);
                db.Kund.Add(kund);

                db.SaveChanges();
            }
        }

        public List<KundKategoriDTO> GetAllKundKategori()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.KundKategori
                            select new KundKategoriDTO { KundKategoriID = x.KundKategoriID, Namn = x.Namn };

                return query.ToList();
            }
        }

        public void AddKundKategori(string namn)
        {
            using (var db = new DataContext())
            {
                var kundKategori = new KundKategori { Namn = namn };
                db.KundKategori.Add(kundKategori);
                db.SaveChanges();
            }
        }
    } 
}
