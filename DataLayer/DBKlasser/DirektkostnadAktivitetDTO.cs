﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DirektkostnadAktivitetDTO
    {
        public int Kontonummer { get; set; }
        public string Konto { get; set; }
        public string AktivitetID { get; set; }
        public string Aktivitet { get; set; }
        public double Belopp { get; set; }

    }
}
