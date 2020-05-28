using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Testdata
{
    public class Testdata
    {
        public List<Tuple<string, double, double>> Persons = new List<Tuple<string, double, double>>
        {
            new Tuple<string, double, double>("Person A", 25000, 1),
            new Tuple<string, double, double>("Person B", 30000, 0.5),
            new Tuple<string, double, double>("Person C", 20000, 0.5),
            new Tuple<string, double, double>("Person D", 35000, 0.5),
        };

        public Dictionary<string, double> ProduktX = new Dictionary<string, double>
        {
            {"Person A", 1},
            {"Person D", 0.5}
        };

        public Dictionary<string, double> ProduktY = new Dictionary<string, double>
        {
            {"Person B", 0.5},
            {"Person C", 0.5}
        };

        public double SchablonKostnad => 13000 * Persons.Sum(x => x.Item3);
        public double Konto5021 => Persons.Sum(x => x.Item2 * x.Item3);
        public double PersRelateradKostnad => SchablonKostnad + Konto5021;
        public double DirektKostnadProduktX => 30000;
        public double DirektKostnadProduktY => 20000;

        public double TB => Marknad5021 + MarknadsDirekt + Admin5021 + AdminDirekt + Avkastningskrav;
        public double Marknad5021 => 5000;
        public double MarknadsDirekt => 2500;
        public double Admin5021 => 20000;
        public double AdminDirekt => 2500;
        public double Avkastningskrav => 20000;

        public double Tillverkningskostnad => Konto5021 + DirektKostnadProduktX + DirektKostnadProduktY + SchablonKostnad;
        public double Avdelning2 => 50000;

        public double TotalkostnadKontor => Avdelning2 + Tillverkningskostnad;
        public double Pålägg => TB / TotalkostnadKontor;
        public double Totalkostnad => Tillverkningskostnad + (Pålägg * Tillverkningskostnad);

        public void ResultatAvdelning() => Console.WriteLine(Totalkostnad);

        public double TillvKostnadX =>
            ((ProduktX.Sum(x => x.Value) / Persons.Sum(x => x.Item3)) * PersRelateradKostnad) + DirektKostnadProduktX;
        public double TillvKostnadY => ((ProduktY.Sum(x => x.Value) / Persons.Sum(x => x.Item3)) * PersRelateradKostnad) + DirektKostnadProduktY;

        public double TBX => Pålägg * TillvKostnadX;
        public double TBY => Pålägg * TillvKostnadY;
        public double TotalKostnadX => TBX + TillvKostnadX;
        public double TotalKostnadY => TBY + TillvKostnadY;

        public void ResultatProduktX() => Console.WriteLine(TotalKostnadX);

        public void ResultatProduktY() => Console.WriteLine(TotalKostnadY);
    }
}
