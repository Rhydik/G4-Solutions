//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produkt()
        {
            this.Personal = new HashSet<Personal>();
        }
    
        public int ProduktID { get; set; }
        public string Namn { get; set; }
    
        public virtual Intäktsbudget Intäktsbudget { get; set; }
        public virtual Prognos Prognos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personal> Personal { get; set; }
        public virtual Produktkategori Produktkategori { get; set; }
        public virtual Produktgrupp Produktgrupp { get; set; }
    }
}
