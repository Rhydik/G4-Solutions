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
    
    public partial class Kund
    {
        public string KundID { get; set; }
        public string Namn { get; set; }
    
        public virtual Intäktsbudget Intäktsbudget { get; set; }
        public virtual KundKategori KundKategori { get; set; }
    }
}
