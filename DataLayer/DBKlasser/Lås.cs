namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lås
    {
        public int LåsID { get; set; }

        public bool Intäktsbudget { get; set; }

        public bool AffoAvdelning { get; set; }
        public bool DriftAvdelning { get; set; }
        public bool UtvFörvAvdelning { get; set; }
        public bool Prognostisering { get; set; }

    }
}
