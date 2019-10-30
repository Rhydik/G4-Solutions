using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class PrognosRepository
    {
        public List<PrognosDTO> GetAllPrognoser()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Prognos
                            select new PrognosDTO { Namn = x.Namn, PrognosID = x.PrognosID, Belopp = x.Belopp };

                return query.ToList();
            }
        }
    }
}
