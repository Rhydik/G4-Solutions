using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class AvdelningPersonalRepository
    {
        public void SetAvdelningPersonal(string avdelningnamn, string personNr, int placering) //Sätter ihop personallistan med avdelningslistan.
        {
            using (var db = new DataContext()) 
            {
                var avdelning = (from x in db.Avdelning
                            where x.Namn == avdelningnamn
                            select x).FirstOrDefault();

                var personal = (from x in db.Personal
                                where x.PersonNr == personNr
                                select x).FirstOrDefault();

                var avdelningPersonal = new AvdelningPersonalxRef { Avdelning = avdelning, Personal = personal, Avdelning_AvdelningID = avdelning.AvdelningID, Personal_PersonalID = personal.PersonalID, Placering = placering };
                db.AvdelningPersonalxRef.Add(avdelningPersonal);

                db.SaveChanges();
            }
        }

        public List<PlaceringsDTO> GetPersonalFördelning(DTO.PersonalDTO personal)
        {
            using (var db = new DataContext())
            {
                var avdelningsfördelning =  from x in db.AvdelningPersonalxRef
                                            where x.Personal_PersonalID == personal.PersonalID
                                            select new PlaceringsDTO { Avdelning = x.Avdelning.Namn, Fördelning = (int)x.Placering };


                return avdelningsfördelning.ToList();
            }
        }
    }
}
