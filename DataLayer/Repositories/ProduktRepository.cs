﻿using DataLayer.DTO;
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
            using (var db = new Databas())
            {
                var query = from x in db.Produkt
                            select new ProduktDTO {ProduktID = x.ProduktID, Namn = x.Namn, Produktgrupp = x.Produktgrupp, Produktkategori = x.Produktkategori};

                return query.ToList();
            }
        }

        public void AddProdukt(string produktKod, string namn, string kategori, string grupp)
        {
            using (var db = new Databas())
            {
                var produktKategori = (from x in db.Produktkategori
                                    where x.Namn == kategori
                                    select x).FirstOrDefault();

                var produktGrupp = (from x in db.Produktgrupp
                                       where x.Namn == grupp
                                       select x).FirstOrDefault();



                var produkt = new Produkt { ProduktKod = produktKod, Namn = namn, Produktkategori = produktKategori, Produktgrupp = produktGrupp};
                db.Produkt.Add(produkt);

                db.SaveChanges();
            }
        }

        //Produktkategori

        public List<ProduktKategoriDTO> GetProduktByKategori()
        {
            using (var db = new Databas())
            {
                var query = from x in db.Produktkategori
                            select new ProduktKategoriDTO {ProduktkategoriID = x.ProduktkategoriID, Namn = x.Namn};
                Console.WriteLine(query);
                return query.ToList();
            }
        }

        //Produktgrupp

        public List<ProduktgruppDTO> GetProduktByGrupp()
        {
            using (var db = new Databas())
            {
                var query = from x in db.Produktgrupp
                            select new ProduktgruppDTO { ProduktgruppID = x.ProduktgruppID, Namn = x.Namn };
                Console.WriteLine(query);
                return query.ToList();
            }
        }

        //Avdelning
        public List<AvdelningDTO> GetProduktByAvdelning()
        {
            using (var db = new Databas())
            {
                var query = from x in db.Avdelning
                            select new AvdelningDTO { AvdelningsID = x.AvdelningID, Namn = x.Namn };
                Console.WriteLine(query);
                return query.ToList();
            }
        }

    }
}
