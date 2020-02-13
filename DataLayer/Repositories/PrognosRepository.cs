using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class PrognosRepository
    {

        public List<LästFilPrognos> lästFilPrognoser = new List<LästFilPrognos>();  /*Inläsning av fil*/

        public List<PrognosDTO> GetAllPrognoser() /*Hämtar alla prognoser*/
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Prognos
                            select new PrognosDTO { Namn = x.Namn, PrognosID = x.PrognosID, Belopp = x.Belopp };

                return query.ToList();
            }
        }

        public void SparaFilMetod(List<LästFilPrognos> prognoser)   /*Metod för att spara fil*/
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

                string myString = string.Join("\t", line);
                string result = Regex.Replace(myString, @"\t{2,}", @"*");
                string invert = Regex.Replace(result, @"\t", @"*");

                if (line == null) break;
                List<string> readLine = new List<string>(invert.Split('*'));



                LästFilPrognos m = new LästFilPrognos();

                if (readLine.Count == 6)
                {
                    if (readLine[0] == "ProduktID" || readLine[0] == null) readLine[0] = "null";
                    else
                    {
                        m.ProduktID = readLine[0];
                    }

                    if (readLine[1] == "Produkt" || readLine[1] == null) m.Produkt = "null";
                    else
                    {
                        m.Produkt = readLine[1];
                    }

                    if (readLine[2] == "KundID" || readLine[2] == null) m.KundID = "null";
                    else
                    {
                        m.KundID = readLine[2];
                    }

                    if (readLine[3] == "Kund" || readLine[3] == null) m.Kund = "null";
                    else
                    {
                        m.Kund = readLine[3];
                    }

                    if (readLine[4] == "Datum" || readLine[4] == null) m.Datum = "null";
                    else
                    {
                        m.Datum = readLine[4];
                    }

                    if (!decimal.TryParse(readLine[5], out decimal belopp))
                    {
                        m.Budget = belopp;
                    }
                    else
                    {
                        m.Budget = decimal.Parse(readLine[5]);
                    }

                    m.UtfallMån = 0;
                    m.UtfallAcc = 0;
                    m.Månad = "null";
                    m.Upparbetat = 0;
                    m.Trend = 0;
                    m.FöregPrognos = 0;
                    m.Prognos = 0;

                }
                else
                {
                    if (readLine[0] == "ProduktID" || readLine[0] == null) readLine[0] = "null";
                    else
                    {
                        m.ProduktID = readLine[0];
                    }

                    if (readLine[1] == "Produkt" || readLine[1] == null) m.Produkt = "null";
                    else
                    {
                        m.Produkt = readLine[1];
                    }

                    if (readLine[2] == "KundID" || readLine[2] == null) m.KundID = "null";
                    else
                    {
                        m.KundID = readLine[2];
                    }

                    if (readLine[3] == "Kund" || readLine[3] == null) m.Kund = "null";
                    else
                    {
                        m.Kund = readLine[3];
                    }

                    if (readLine[4] == "Datum" || readLine[4] == null) m.Datum = "null";
                    else
                    {
                        m.Datum = readLine[4];
                    }

                    if (!decimal.TryParse(readLine[5], out decimal belopp))
                    {
                        m.Budget = belopp;
                    }
                    else
                    {
                        m.Budget = decimal.Parse(readLine[5]);
                    }

                    if (!decimal.TryParse(readLine[6], out decimal utfallMån))
                    {
                        m.UtfallMån = utfallMån;
                    }
                    else
                    {
                        m.UtfallMån = decimal.Parse(readLine[6]);
                    }

                    if (!decimal.TryParse(readLine[7], out decimal utfallAcc))
                    {
                        m.UtfallAcc = utfallAcc;
                    }
                    else
                    {
                        m.UtfallAcc = decimal.Parse(readLine[7]);
                    }


                    if (readLine[8] == "Månad" || readLine[8] == null) m.Månad = "null";
                    else
                    {
                        m.Månad = readLine[8];
                    }


                    if (!decimal.TryParse(readLine[9], out decimal upparbetat))
                    {
                        m.Upparbetat = upparbetat;
                    }
                    else
                    {
                        m.Upparbetat = decimal.Parse(readLine[9]);
                    }

                    if (!decimal.TryParse(readLine[10], out decimal trend))
                    {
                        m.Trend = trend;
                    }
                    else
                    {
                        m.Trend = decimal.Parse(readLine[10]);
                    }

                    if (!decimal.TryParse(readLine[11], out decimal föregPrognos))
                    {
                        m.FöregPrognos = föregPrognos;
                    }
                    else
                    {
                        m.FöregPrognos = decimal.Parse(readLine[11]);
                    }

                    if (!decimal.TryParse(readLine[12], out decimal prognos))
                    {
                        m.Prognos = prognos;
                    }
                    else
                    {
                        m.Prognos = decimal.Parse(readLine[12]);
                    }

                    if (!decimal.TryParse(readLine[13], out decimal prognosBudget))
                    {
                        m.PrognosBudget = prognosBudget;
                    }
                    else
                    {
                        m.PrognosBudget = decimal.Parse(readLine[13]);
                    }
                }

                lästFilPrognoser.Add(m);
            }


            lästFilPrognoser.RemoveAt(0);


            infil.Close();
            return lästFilPrognoser;
        }

        public LästFilPrognos RäknaUtBudgetPrognos(List<LästFilPrognos> prognoser)      /*Budgeträkning Prognostisering*/
        {
            LästFilPrognos totalPrognos = new LästFilPrognos();
            foreach (var item in prognoser) //Sammanräkning av alla attribut i ett objekt.  Objektet för det "totala" visas i datagridview1 sedan.
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

        public List<LästFilPrognos> FörberedaExport(LästFilPrognos transfer, List<LästFilPrognos> prognoser)    //Förebereder Export av Prognos
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
