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
            using (var db = new Databas())
            {
                var query = from x in db.Personal
                            where x.PersonNr == användarnamn && x.Lösenord == lösenord
                            select x;
                return query.FirstOrDefault();
            }
        }
    }
}
