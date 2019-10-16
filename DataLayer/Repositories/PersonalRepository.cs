using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PersonalRepository
    {
        public Personal Login(string användarnamn, string lösenord)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            where x.PersonNr == användarnamn && x.Lösenord == lösenord
                            select x;
                return query.FirstOrDefault();
            }
        }

        public List<Personal> GetAllPersonal()
        {
            using (var db = new DataContext())
            {
                return db.Personal.ToList();
            }
        }

        public List<Personal> GetPersonalByPersNr(string persNr)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            where x.PersonNr.StartsWith(persNr)
                            select x;
                return query.ToList();
            }
        }

        public List<Personal> GetPersonalByNamn(string namn)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            where x.Namn.StartsWith(namn)
                            select x;
                return query.ToList();
            }
        }

        public void AddPersonal(Personal personal)
        {
            using (var db = new DataContext())
            {
                var personalen = new Personal();
                personalen.Sysselsättningsgrad = personal.Sysselsättningsgrad;
                personalen.Namn = personal.Namn;
                personalen.PersonNr = personal.PersonNr;
                personalen.Vakansavdrag = personal.Vakansavdrag;
                personalen.Behörighet = personal.Behörighet;
                personalen.Lösenord = personal.Lösenord;
                personalen.Avdelning = personal.Avdelning;
                personalen.AntalTimmar = personal.AntalTimmar;
                personalen.Behörighet = personal.Behörighet;
                personalen.Månadslön = personal.Månadslön;
                personalen.PersonalProdukt = personal.PersonalProdukt;
                personalen.PersonalID = personal.PersonalID;

                db.Personal.Add(personalen);
                db.SaveChanges();
            }
        }

        public void RemovePersonal(Personal personal)
        {
            using (var db = new DataContext())
            {
                var personalen = db.Personal.Where(x => x.PersonalID == personal.PersonalID).FirstOrDefault();
                db.Personal.Remove(personalen);
                db.SaveChanges();
            }
        }

        public void UpdatePersonal(Personal personal)
        {
            using (var db = new DataContext())
            {
                var query = db.Personal.Where(x => x.PersonNr == personal.PersonNr).FirstOrDefault();

                query.PersonNr = personal.PersonNr;
                query.Namn = personal.Namn;
                query.Sysselsättningsgrad = personal.Sysselsättningsgrad;
                query.Vakansavdrag = personal.Vakansavdrag;

                db.SaveChanges();
            }
        }
    }
}
