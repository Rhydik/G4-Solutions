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
                            orderby x.Namn
                            select new ProduktDTO {ProduktID = x.ProduktID, Namn = x.Namn, Produktgrupp = x.Produktgrupp.Namn, Produktkategori = x.Produktkategori.Namn, Avdelning = x.Avdelning.Namn};

                return query.ToList();
            }
        }

        public void AddProdukt(string produktID, string namn, string kategori, string grupp, string avdelning)
        {
            using (var db = new DataContext())
            {
                var produktKategori = (from x in db.Produktkategori
                                    where x.Namn == kategori
                                    select x).FirstOrDefault();

                var produktGrupp = (from x in db.Produktgrupp
                                       where x.Namn == grupp
                                       select x).FirstOrDefault();

                var produktAvdelning = (from x in db.Avdelning
                                        where x.Namn == avdelning
                                        select x).FirstOrDefault();

                var produkt = new Produkt {ProduktID = produktID , Namn = namn, Produktkategori = produktKategori, Produktgrupp = produktGrupp, Avdelning = produktAvdelning};
                db.Produkt.Add(produkt);
                db.SaveChanges();
            }
        }


        //Uppdatera produkt
        public void UpdateProdukt(ProduktDTO oldProdukt, string produktID, string namn, string produktKategori, string produktGrupp, string produktAvdelning)
        {
            using (var db = new DataContext())
            {
                var prodKat = (from x in db.Produktkategori
                                    where x.Namn == produktKategori
                                    select x).FirstOrDefault();

                var prodGrupp = (from x in db.Produktgrupp
                                    where x.Namn == produktGrupp
                                    select x).FirstOrDefault();

                var prodAvdelning = (from x in db.Avdelning
                                     where x.Namn == produktAvdelning
                                     select x).FirstOrDefault();

                var tempProdukt = (from x in db.Produkt
                                where x.ProduktID == oldProdukt.ProduktID
                                select x).FirstOrDefault();

                var produkt = new Produkt { ProduktID = produktID, Namn = namn, Produktkategori = prodKat, Produktgrupp = prodGrupp, Avdelning = prodAvdelning };
                db.Produkt.Remove(tempProdukt);
                db.Produkt.Add(produkt);


                db.SaveChanges();
            }
        }

        public void RemoveProdukt(ProduktDTO produkt)
        {
            using (var db = new DataContext())
            {
                var produkten = db.Produkt.Where(x => x.ProduktID == produkt.ProduktID).FirstOrDefault();
                db.Produkt.Remove(produkten);
                db.SaveChanges();
            }
        }



        //Produktkategori

        public List<ProduktKategoriDTO> GetProduktByKategori()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produktkategori
                            orderby x.Namn
                            select new ProduktKategoriDTO {ProduktkategoriID = x.ProduktkategoriID, Namn = x.Namn};
                Console.WriteLine(query);
                return query.ToList();
            }
        }

        //Produktgrupp

        public List<ProduktgruppDTO> GetProduktByGrupp()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produktgrupp
                            orderby x.Namn
                            select new ProduktgruppDTO { ProduktgruppID = x.ProduktgruppID, Namn = x.Namn };
                Console.WriteLine(query);
                return query.ToList();
            }
        }

        //Avdelning
        public List<AvdelningDTO> GetProduktByAvdelning()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Avdelning
                            select new AvdelningDTO { AvdelningsID = x.AvdelningID, Namn = x.Namn };
                Console.WriteLine(query);
                return query.ToList();
            }
        }

        public void AddProduktGrupp(string namn)
        {
            using (var db = new DataContext())
            {               
                var produktgrupp = new Produktgrupp {Namn = namn};
                db.Produktgrupp.Add(produktgrupp);
                db.SaveChanges();
            }
        }
        
        public void AddProduktKategori(string namn)
        {
            using (var db = new DataContext())
            {
                var produktkategori = new Produktkategori { Namn = namn };
                db.Produktkategori.Add(produktkategori);
                db.SaveChanges();
            }
        }
    }
}
