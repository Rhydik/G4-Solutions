namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("schablonkostnad")]
    public partial class schablonkostnad
    {
        public int schablonkostnadID { get; set; }

        public decimal Belopp { get; set; }

        public int Konto_KontoID { get; set; }

        public virtual Konto Konto { get; set; }
    }
}
