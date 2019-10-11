﻿using DataLayer.DTO;
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
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori };

                return query.ToList();
            }
        }
        public List<KundDTO> GetKunderByNamn(string namn)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Kund
                            where x.Namn == namn
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori };

                return query.ToList();
            }
        }
        public List<KundDTO> GetKunderByKategori(string kategori)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Kund
                            where x.KundKategori.ToString() == kategori
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori };

                return query.ToList();
            }
        }
        public List<KundDTO> GetAllKunder()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Kund
                            select new KundDTO { KundID = x.KundID, Namn = x.Namn, KundKategori = x.KundKategori };

                return query.ToList();
            }                
        }

        //public void AddKund()  för testning//Leo
        //{
        //    using (var db = new DataContext())
        //    {
        //       var namn = "testperson";
        //        var kat = 1;

        //        var kund = new Kund {Namn = namn, KundKategori_KundKategoriID = kat};
        //        db.Kund.Add(kund);
        //        db.SaveChanges();

        //    }
        //}
    }
}
