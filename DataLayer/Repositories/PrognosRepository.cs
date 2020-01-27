using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class PrognosRepository
    {

        public List<LästFilPrognos> lästFilPrognoser = new List<LästFilPrognos>();

        public List<PrognosDTO> GetAllPrognoser()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Prognos
                            select new PrognosDTO { Namn = x.Namn, PrognosID = x.PrognosID, Belopp = x.Belopp };

                return query.ToList();
            }
        }

        public void SparaFilMetod(List<LästFilPrognos> prognoser)
        {
            using (StreamWriter utfil = new StreamWriter("IntäktProduktKund.txt"))
            {
                for (int i = 0; i < prognoser.Count; i++) //bara en for loop som går igenom listan och skriver ut rad för rad
                {
                    LästFilPrognos m = prognoser[i];
                    utfil.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}", m.ProduktID, m.Produkt, m.KundID, m.Kund, m.Datum, m.Budget, m.UtfallMån, m.UtfallAcc, m.Månad, m.Upparbetat, m.Trend, m.FöregPrognos, m.Prognos, m.PrognosBudget);
                }
                utfil.Close();
            }
        }
    }
}
