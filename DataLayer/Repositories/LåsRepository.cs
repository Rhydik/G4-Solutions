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
        public bool GetIntäktsLås() //Metod för att låsa intäkter
        {

            using (var db = new DataContext())
            {
                var query = from x in db.Lås
                            where x.LåsID == 1
                            select x.Intäktsbudget;

                return query.FirstOrDefault();
            }

        }

        public void SetIntäktsLås(bool boolean) //Metod för att låsa intäkter
        {
            using (var db = new DataContext())
            {
                var lås = db.Lås.Where(x => x.LåsID == 1).FirstOrDefault();
                lås.Intäktsbudget = boolean;
                db.SaveChanges();
            }
        }
        public bool GetKostnadsLås(int id) //Metod för att låsa kostnader
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Lås
                            where x.LåsID == 1
                            select x.AffoAvdelning;

                return query.FirstOrDefault();
            }
        }
        public void SetKostnadsLås(bool boolean) //Metod för att låsa kostnader
        {
            using (var db = new DataContext())
            {
                var lås = db.Lås.Where(x => x.LåsID == 1).FirstOrDefault();
                lås.AffoAvdelning = boolean;
                db.SaveChanges();
            }
        }
    }
}
