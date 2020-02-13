namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KundIntäktsbudget
    {
        [Key]
        [Column(Order = 0)]
        public string Kund_KundID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Intäktsbudget_IntäktsbudgetID { get; set; }

        public virtual Intäktsbudget Intäktsbudget { get; set; }
    }
}
