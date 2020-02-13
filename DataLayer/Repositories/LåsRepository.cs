using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class LåsRepository
    {
        public bool GetIntäktsLås()
        {

            using (var db = new DataContext())
            {
                var query = from x in db.Lås
                            where x.LåsID == 1
                            select x.Intäktsbudget;

                return query.FirstOrDefault();
            }

        }

        public void SetIntäktsLås(bool boolean)
        {
            using (var db = new DataContext())
            {
                var lås = db.Lås.Where(x => x.LåsID == 1).FirstOrDefault();
                lås.Intäktsbudget = boolean;
                db.SaveChanges();
            }
        }
        public bool GetAffoLås()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Lås
                            where x.LåsID == 1
                            select x.AffoAvdelning;

                return query.FirstOrDefault();
            }
        }
        public void SetAffoLås(bool boolean)
        {
            using (var db = new DataContext())
            {
                var lås = db.Lås.Where(x => x.LåsID == 1).FirstOrDefault();
                lås.AffoAvdelning = boolean;
                db.SaveChanges();
            }
        }

        public bool GetDriftLås()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Lås
                            where x.LåsID == 1
                            select x.DriftAvdelning;

                return query.FirstOrDefault();
            }
        }
        public void SetDriftLås(bool boolean)
        {
            using (var db = new DataContext())
            {
                var lås = db.Lås.Where(x => x.LåsID == 1).FirstOrDefault();
                lås.DriftAvdelning = boolean;
                db.SaveChanges();
            }
        }
        public bool GetUtvFörvLås()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Lås
                            where x.LåsID == 1
                            select x.UtvFörvAvdelning;

                return query.FirstOrDefault();
            }
        }
        public void SetUtvFörvLås(bool boolean)
        {
            using (var db = new DataContext())
            {
                var lås = db.Lås.Where(x => x.LåsID == 1).FirstOrDefault();
                lås.UtvFörvAvdelning = boolean;
                db.SaveChanges();
            }
        }

        public bool GetProgLås()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Lås
                            where x.LåsID == 1
                            select x.Prognostisering;

                return query.FirstOrDefault();
            }
        }
        public void SetProgLås(bool boolean)
        {
            using (var db = new DataContext())
            {
                var lås = db.Lås.Where(x => x.LåsID == 1).FirstOrDefault();
                lås.Prognostisering = boolean;
                db.SaveChanges();
            }
        }
    }
}
