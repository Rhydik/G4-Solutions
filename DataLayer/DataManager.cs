using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataManager
    {
        public static List<Kund> GetKunder()
        {
            using (var db = new Database())
            {
                return db.Kund.ToList();
            }
        }

        public static List<Produkt> GetProdukter()
        {
            using (var db = new Database())
            {
                return db.Produkt.ToList();
            }
        }

        public static List<Personal> GetPersonal()
        {
            using (var db = new Database())
            {
                return db.Personal.ToList();
            }
        }

        public static List<Aktivitet> GetAktiviteter()
        {
            using (var db = new Database())
            {
                return db.Aktivitet.ToList();
            }
        }

        public static List<schablonkostnad> GetSchablonkostnader()
        {
            using (var db = new Database())
            {
                return db.schablonkostnad.ToList();
            }
        }

    }
}
