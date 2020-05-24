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
        public List<ProduktDTO> GetAllProdukter() //Metod som hämtar alla produkter.
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt
                            orderby x.Namn
                            select new ProduktDTO {ProduktID = x.ProduktID, Namn = x.Namn, Produktgrupp = x.Produktgrupp.Namn, Produktkategori = x.Produktkategori.Namn, Avdelning = x.Avdelning.Namn};

                return query.ToList();
            }
        }

        public void AddProdukt(string produktID, string namn, string kategori, string grupp, string avdelning) //Metoden som lägger till en ny produkt.
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
        public void UpdateProdukt(ProduktDTO oldProdukt, string produktID, string namn, string produktKategori, string produktGrupp, string produktAvdelning) //Metoden som ändrar en befintlig produkt.
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

        public bool CheckAvdelning(string avdelning)        //Med som kollar vilken avdelning produkten står under.
        {
            using (var db = new DataContext())
            {
                var query = (from x in db.Avdelning
                            where x.Namn.ToLower() == avdelning.ToLower()
                            select x).FirstOrDefault();
                if (query != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void CreateAvdelning(string avdelning)       //Metod för att skapa avdelning.
        {
            using (var db = new DataContext())
            {
                Avdelning avd = new Avdelning() { Namn = avdelning };
                db.Avdelning.Add(avd);
                db.SaveChanges();
            }
        }

        public void RemoveProdukt(ProduktDTO produkt)           //Metod för att ta bort produkt
        {
            using (var db = new DataContext())
            {
                var produkten = db.Produkt.Where(x => x.ProduktID == produkt.ProduktID).FirstOrDefault();
                var kostnadProdukt = (from x in db.DirektkostnadProdukt
                                      where x.Produkt.ProduktID == produkt.ProduktID
                                      select x).FirstOrDefault();

                db.DirektkostnadProdukt.Remove(kostnadProdukt);
                db.Produkt.Remove(produkten);
                db.SaveChanges();
            }
        }



        //Produktkategori

        public List<ProduktKategoriDTO> GetProduktByKategori()          //Metod för att hämta produkt efter kategori.
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

        public List<ProduktgruppDTO> GetProduktByGrupp()        //Metod för att hämta produkt efter produktgrupp.
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
        public List<AvdelningDTO> GetProduktByAvdelning()           //Metod för att hämta produkt efter avdelning
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Avdelning
                            select new AvdelningDTO { AvdelningsID = x.AvdelningID, Namn = x.Namn };
                Console.WriteLine(query);
                return query.ToList();
            }
        }

        public void AddProduktGrupp(string namn)            //Metod för att lägga till produktgrupp.
        {
            using (var db = new DataContext())
            {               
                var produktgrupp = new Produktgrupp {Namn = namn};
                db.Produktgrupp.Add(produktgrupp);
                db.SaveChanges();
            }
        }
        
        public void AddProduktKategori(string namn)         //Metod för att lägga till Produktkategori
        {
            using (var db = new DataContext())
            {
                var produktkategori = new Produktkategori { Namn = namn };
                db.Produktkategori.Add(produktkategori);
                db.SaveChanges();
            }
        }

        public List<ProduktDTO> GetProdukterBySearch(string produktID, string namn, string produktKategori, string produktGrupp, string produktAvdelning) //Metod för sökfunktionen inom produkter
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt
                            select new ProduktDTO { ProduktID = x.ProduktID, Namn = x.Namn, Produktkategori = x.Produktkategori.Namn, Produktgrupp = x.Produktgrupp.Namn, Avdelning = x.Avdelning.Namn };

                if (!string.IsNullOrEmpty(produktID))
                    query = query.Where(ProduktDTO => ProduktDTO.ProduktID.StartsWith(produktID));

                if (!string.IsNullOrEmpty(namn))
                    query = query.Where(ProduktDTO => ProduktDTO.Namn.StartsWith(namn));

                if (!string.IsNullOrEmpty(produktKategori))
                    query = query.Where(ProduktDTO => ProduktDTO.Produktkategori == produktKategori);

                if (!string.IsNullOrEmpty(produktGrupp))
                    query = query.Where(ProduktDTO => ProduktDTO.Produktgrupp == produktGrupp);

                if (!string.IsNullOrEmpty(produktAvdelning))
                    query = query.Where(ProduktDTO => ProduktDTO.Avdelning == produktAvdelning);

                return query.ToList();
            }
        }

        public List<ProduktDTO> GetProduktByNamn(string produktnamn)            //Metod för att hämta produkter efter namn.
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt
                            where x.Namn.StartsWith(produktnamn)
                            select new ProduktDTO { Namn = x.Namn, Avdelning = x.Avdelning.Namn, Produktgrupp = x.Produktgrupp.Namn, ProduktID = x.ProduktID, Produktkategori = x.Produktkategori.Namn };

                return query.ToList();
            }
        }
    }
}
