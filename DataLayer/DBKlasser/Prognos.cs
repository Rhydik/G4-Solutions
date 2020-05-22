namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prognos
    {
        public int PrognosID { get; set; }

        [Required]
        public string Namn { get; set; }

        public DateTime Datum { get; set; }

        public double Belopp { get; set; }

        public int Intäktsbudget_IntäktsbudgetID { get; set; }

        public virtual Intäktsbudget Intäktsbudget { get; set; }
    }
}
