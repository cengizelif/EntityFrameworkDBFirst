//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkDBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bolgeler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bolgeler()
        {
            this.Personeller = new HashSet<Personeller>();
        }
    
        public string TerritoryID { get; set; }
        public string TerritoryTanimi { get; set; }
        public int BolgeID { get; set; }
    
        public virtual Bolge Bolge { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personeller> Personeller { get; set; }
    }
}