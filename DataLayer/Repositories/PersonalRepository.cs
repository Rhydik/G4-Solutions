using DataLayer.DTO;
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

        public List<PersonalDTO> GetAllPersonal()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                               select new PersonalDTO { PersonalID = x.PersonalID, Namn = x.Namn, PersonNr = x.PersonNr, Sysselsättningsgrad = x.Sysselsättningsgrad, Vakansavdrag = x.Vakansavdrag, Månadslön = x.Månadslön, Årsarbete = x.Sysselsättningsgrad - x.Vakansavdrag };
                               
                return query.ToList();
            }
        }

        public List<PlaceringsDTO> GetAllAVdelningarFördelning()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Avdelning
                            select new PlaceringsDTO { Avdelning = x.Namn };

                return query.ToList();
            }
        }

        public List<PersonalDTO> GetPersonalByPersNr(string persNr)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            where x.PersonNr.StartsWith(persNr)
                            select new PersonalDTO { PersonalID = x.PersonalID, Namn = x.Namn, PersonNr = x.PersonNr, Sysselsättningsgrad = x.Sysselsättningsgrad, Vakansavdrag = x.Vakansavdrag };

                return query.ToList();
            }
        }

        public List<PersonalDTO> GetPersonalByNamn(string namn)
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            where x.Namn.StartsWith(namn)
                            select new PersonalDTO { PersonalID = x.PersonalID, Namn = x.Namn, PersonNr = x.PersonNr, Sysselsättningsgrad = x.Sysselsättningsgrad, Vakansavdrag = x.Vakansavdrag };

                return query.ToList();
            }
        }

        public void AddPersonal(int sysselsättningsgrad, string namn, string personNr, int vakansavdrag, string lösenord, int månadslön, string årsarbetare, string roll)
        {
            using (var db = new DataContext())
            {


                var personal = new Personal() {
                    Sysselsättningsgrad = sysselsättningsgrad,
                    Namn = namn,
                    PersonNr = personNr,
                    Vakansavdrag = vakansavdrag,
                    Behörighet = roll,
                    Lösenord = lösenord,
                    Månadslön = månadslön,
                    //PersonalProdukt = personal.PersonalProdukt,
                    //PersonalID = personal.PersonalID
                };


                db.Personal.Add(personal);
                db.SaveChanges();
            }
        }

        public void RemovePersonal(PersonalDTO personal)
        {
            using (var db = new DataContext())
            {
                var personalen = db.Personal.Where(x => x.PersonalID == personal.PersonalID).FirstOrDefault();
                db.Personal.Remove(personalen);
                db.SaveChanges();
            }
        }

        public void UpdatePersonal(PersonalDTO personal)
        {
            using (var db = new DataContext())
            {
                var query = db.Personal.Where(x => x.PersonalID == personal.PersonalID).FirstOrDefault();

                query.PersonNr = personal.PersonNr;
                query.Namn = personal.Namn;
                query.Sysselsättningsgrad = personal.Sysselsättningsgrad;
                query.Vakansavdrag = personal.Vakansavdrag;

                db.SaveChanges();
            }
        }
    }
}
