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
        public Personal Login(string användarnamn, string lösenord)     //Metoden för inloggning till hela systemet/programmet. 
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            where x.PersonNr == användarnamn && x.Lösenord == lösenord
                            select x;
                return query.FirstOrDefault();
            }
        }

        public List<PersonalDTO> GetAllPersonal()           //Metod för att hämta personal.
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                               select new PersonalDTO { PersonalID = x.PersonalID, Namn = x.Namn, PersonNr = x.PersonNr, Sysselsättningsgrad = x.Sysselsättningsgrad, Vakansavdrag = x.Vakansavdrag, Månadslön = x.Månadslön, Årsarbete = x.Sysselsättningsgrad - x.Vakansavdrag };
                               
                return query.ToList();
            }
        }

        public List<PlaceringsDTO> GetAllAVdelningarFördelning()        //Metod för att hantera avdelningsplacerad personal.
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Avdelning
                            select new PlaceringsDTO { Avdelning = x.Namn };

                return query.ToList();
            }
        }

        public List<PersonalDTO> GetPersonalByPersNr(string persNr)        //Metod för att hämta personal efter personnummers.
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            where x.PersonNr.StartsWith(persNr)
                            select new PersonalDTO { PersonalID = x.PersonalID, Namn = x.Namn, PersonNr = x.PersonNr, Sysselsättningsgrad = x.Sysselsättningsgrad, Vakansavdrag = x.Vakansavdrag };

                return query.ToList();
            }
        }

        public List<PersonalDTO> GetPersonalByNamn(string namn)         //Metod för att hämta personal efter namn.
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            where x.Namn.StartsWith(namn)
                            select new PersonalDTO { PersonalID = x.PersonalID, Namn = x.Namn, PersonNr = x.PersonNr, Sysselsättningsgrad = x.Sysselsättningsgrad, Vakansavdrag = x.Vakansavdrag };

                return query.ToList();
            }
        }

        public void AddPersonal(int sysselsättningsgrad, string namn, string personNr, int vakansavdrag, string lösenord, int månadslön, string roll)              //Metod för att lägga till ny personal.
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
                    Årsarbete = sysselsättningsgrad - vakansavdrag
                    //PersonalProdukt = personal.PersonalProdukt,
                    //PersonalID = personal.PersonalID
                };


                db.Personal.Add(personal);
                db.SaveChanges();
            }
        }

        public List<KonstnadsbudgetPersonalDTO> GetPersonalByAvdelning(string avdelning)                //Metod för att hämta personal efter avdelning.
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            join y in db.AvdelningPersonalxRef on x.PersonalID equals y.Personal_PersonalID
                            where y.Avdelning.Namn == avdelning & y.Placering > 0
                            select new KonstnadsbudgetPersonalDTO { PersonalID = x.PersonalID, Namn = x.Namn, Sysselsättningsgrad = x.Sysselsättningsgrad, Vakansavdrag = x.Vakansavdrag, Årsarbetare = x.Sysselsättningsgrad - x.Vakansavdrag };

                return query.ToList();
            }
        }

        public void RemovePersonal(PersonalDTO personal)        //Metod för att radera personal ur databasen/registret.
        {
            using (var db = new DataContext())
            {
                var avdelningpers = from x in db.AvdelningPersonalxRef
                                    where x.Personal_PersonalID == personal.PersonalID
                                    select x;
                foreach (var item in avdelningpers)
                {
                    db.AvdelningPersonalxRef.Remove(item);
                }

                var personalen = db.Personal.Where(x => x.PersonalID == personal.PersonalID).FirstOrDefault();
                db.Personal.Remove(personalen);
                db.SaveChanges();
            }
        }

        public void UpdatePersonal(PersonalDTO personal)                //Metod för att ändra personaluppgifter.
        {
            using (var db = new DataContext())
            {
                var query = db.Personal.Where(x => x.PersonalID == personal.PersonalID).FirstOrDefault();

                query.PersonNr = personal.PersonNr;
                query.Namn = personal.Namn;
                query.Månadslön = (int)personal.Månadslön;
                query.Sysselsättningsgrad = personal.Sysselsättningsgrad;
                query.Vakansavdrag = personal.Vakansavdrag;
                query.Årsarbete = personal.Årsarbete;

                db.SaveChanges();
            }
        }
    }
}
