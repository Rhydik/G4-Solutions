﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class KostnadsbudgetProduktDTO
    {
        public string ProduktID { get; set; }
        public string Produkt { get; set; }
        public double Summering { get; set; } 
        public int Avdelning_AvdelningID { get; set; }
    }
}
