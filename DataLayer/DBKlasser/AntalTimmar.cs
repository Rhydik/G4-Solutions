namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AntalTimmar")]
    public partial class AntalTimmar
    {
        public int AntalTimmarID { get; set; }

        public int Adm { get; set; }

        public int FörsMark { get; set; }

        public int UtvFörv { get; set; }

        public int Drift { get; set; }

        public int Personal_PersonalID { get; set; }

        public virtual Personal Personal { get; set; }
    }
}
