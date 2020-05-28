using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Testdata
{
    public class Testdata
    {
        public List<Person> Persons = new List<Person>
        {
            new Person() {Månadslön = 25000, Namn = "Person A", Placering = 100, Produkt = "ProduktX"},
            new Person() {Månadslön = 30000, Namn = "Person B", Placering = 50, Produkt = "ProduktY"},
            new Person() {Månadslön = 20000, Namn = "Person C", Placering = 50, Produkt = "ProduktY"},
            new Person() {Månadslön = 35000, Namn = "Person D", Placering = 50, Produkt = "ProduktX"},
        };

        public List<Person> ProduktX = new List<Person>
        {
            new Person() {Månadslön = 25000, Namn = "Person A", Placering = 100, Produkt = "ProduktX"},
            new Person() {Månadslön = 35000, Namn = "Person D", Placering = 50, Produkt = "ProduktX"}
        };

        public List<Person> ProduktY = new List<Person>
        {
            new Person() {Månadslön = 30000, Namn = "Person B", Placering = 50, Produkt = "ProduktY"},
            new Person() {Månadslön = 20000, Namn = "Person C", Placering = 50, Produkt = "ProduktY"},
        };

        public double SchablonKostnadBas => 13000;
        public double SchablonKostnad => 13000 * Persons.Sum(x => x.Placering);
        public double Konto5021 => Persons.Sum(x => x.Månadslön * x.Placering);
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
            ((ProduktX.Sum(x => x.Placering) / Persons.Sum(x => x.Placering)) * PersRelateradKostnad) + DirektKostnadProduktX;
        public double TillvKostnadY => ((ProduktY.Sum(x => x.Placering) / Persons.Sum(x => x.Placering)) * PersRelateradKostnad) + DirektKostnadProduktY;

        public double TBX => Pålägg * TillvKostnadX;
        public double TBY => Pålägg * TillvKostnadY;
        public double TotalKostnadX => TBX + TillvKostnadX;
        public double TotalKostnadY => TBY + TillvKostnadY;

        public void ResultatProduktX() => Console.WriteLine(TotalKostnadX);

        public void ResultatProduktY() => Console.WriteLine(TotalKostnadY);

        public class Person
        {
            public string Namn { get; set; }
            public double Månadslön { get; set; }
            public double Placering { get; set; }
            public string Produkt { get; set; }
    }
    }
}
