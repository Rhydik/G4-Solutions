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

        public List<LästFilPrognos> LaddaRegister()
        {
            StreamReader infil = new StreamReader("IntäktProduktKund.txt");
            List<LästFilPrognos> lästFilPrognoser = new List<LästFilPrognos>();
            while (true)
            {
                string line = infil.ReadLine();

                if (line == null) break;
                List<string> LästRad = new List<string>(line.Split('\t'));
                LästFilPrognos m = new LästFilPrognos();

                m.ProduktID = LästRad[0];
                m.Produkt = LästRad[1];
                m.KundID = LästRad[2];
                m.Kund = LästRad[3];
                m.Datum = LästRad[4];
                m.Budget = decimal.Parse(LästRad[5]);
                m.UtfallMån = decimal.Parse(LästRad[6]);
                m.UtfallAcc = decimal.Parse(LästRad[7]);
                m.Månad = LästRad[8];
                m.Upparbetat = decimal.Parse(LästRad[9]);
                m.Trend = decimal.Parse(LästRad[10]);
                m.FöregPrognos = decimal.Parse(LästRad[11]);
                m.Prognos = decimal.Parse(LästRad[12]);
                m.PrognosBudget = decimal.Parse(LästRad[13]);

                lästFilPrognoser.Add(m);
            }

            infil.Close();
            return lästFilPrognoser; 
        }

        public LästFilPrognos RäknaUtBudgetPrognos(List<LästFilPrognos> prognoser)
        {
            LästFilPrognos totalPrognos = new LästFilPrognos();
            foreach (var item in prognoser) //sammanräkning av alla attribut i ett objekt.  Objektet för det "totala" visas i datagridview1 sedan.
            {
                decimal resultatBudget;
                resultatBudget = item.Budget;
                totalPrognos.Budget = totalPrognos.Budget + resultatBudget;

                decimal resultatPrognos;
                resultatPrognos = item.Prognos;
                totalPrognos.Prognos = totalPrognos.Prognos + resultatPrognos;

                decimal resultatUtfallAcc;
                resultatUtfallAcc = item.UtfallAcc;
                totalPrognos.UtfallAcc = totalPrognos.UtfallAcc + resultatUtfallAcc;

                decimal resultatUtfallMån;
                resultatUtfallMån = item.UtfallMån;
                totalPrognos.UtfallMån = totalPrognos.UtfallMån + resultatUtfallMån;

                decimal resultatUpparbetat;
                resultatUpparbetat = item.Upparbetat;
                totalPrognos.Upparbetat = totalPrognos.Upparbetat + resultatUpparbetat;

                decimal resultatTrend;
                resultatTrend = item.Trend;
                totalPrognos.Trend = totalPrognos.Trend + resultatTrend;

                decimal resultatFöregPrognos;
                resultatFöregPrognos = item.FöregPrognos;
                totalPrognos.FöregPrognos = totalPrognos.FöregPrognos + resultatFöregPrognos;

                decimal resultatPrognosBudget;
                resultatPrognosBudget = item.PrognosBudget;
                totalPrognos.PrognosBudget = totalPrognos.PrognosBudget + resultatPrognosBudget;

                foreach (LästFilPrognos lästFil in prognoser)
                {
                    decimal.TryParse(lästFil.UtfallAcc.ToString(), out decimal Grade10);
                    decimal.TryParse(lästFil.Upparbetat.ToString(), out decimal Grade20);

                    decimal dela = new decimal();
                    decimal total = new decimal();
                    dela = int.Parse(DateTime.Now.Month.ToString()) * 12;
                    total = Grade10 + Grade20;

                    var trend = (total / dela);
                    trend = Math.Round(trend, 2);
                    lästFil.Trend = trend;
                }
            }

            



            totalPrognos.Produkt = "Totalt";
            totalPrognos.Kund = "";
            totalPrognos.KundID = "";
            totalPrognos.Månad = "";
            totalPrognos.Datum = "";
            totalPrognos.ProduktID = "";





            return totalPrognos;
        }

        public List<LästFilPrognos> FörberedaExport(LästFilPrognos transfer, List<LästFilPrognos> prognoser)
        {
            List<LästFilPrognos> förberedLista = new List<LästFilPrognos>();

            foreach (var item in prognoser)
            {
                förberedLista.Add(item);
            }

            LästFilPrognos ls = new LästFilPrognos(); //ett nytt objekt skapas för att lägga till "totalt" sist i listan
            ls.Budget = transfer.Budget;
            ls.Datum = transfer.Datum;
            ls.FöregPrognos = transfer.FöregPrognos;
            ls.Kund = transfer.Kund;
            ls.KundID = transfer.KundID;
            ls.Månad = transfer.Månad;
            ls.Produkt = transfer.Produkt;
            ls.ProduktID = transfer.ProduktID;
            ls.Prognos = transfer.Prognos;
            ls.PrognosBudget = transfer.PrognosBudget;
            ls.Trend = transfer.Trend;
            ls.Upparbetat = transfer.Upparbetat;
            ls.UtfallAcc = transfer.UtfallAcc;
            ls.UtfallMån = transfer.UtfallMån;

            förberedLista.Add(transfer);

            

            return förberedLista;

            
        }
    }
}
