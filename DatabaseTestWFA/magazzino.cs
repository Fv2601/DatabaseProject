//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class magazzino
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public magazzino()
        {
            this.accessorios = new HashSet<accessorio>();
            this.biciclettas = new HashSet<bicicletta>();
        }
    
        public long CapienzaMassimaAccessori { get; set; }
        public long CapienzaMassimaBici { get; set; }
        public string IDmagazzino { get; set; }
        public string IDIndirizzo { get; set; }
        public string IDsede { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<accessorio> accessorios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bicicletta> biciclettas { get; set; }
        public virtual indirizzo indirizzo { get; set; }
        public virtual sede sede { get; set; }
    }
}
