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
    
    public partial class tappa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tappa()
        {
            this.sequenzas = new HashSet<sequenza>();
        }
    
        public string Inizio { get; set; }
        public string Fine { get; set; }
        public float LunghezzaTappa { get; set; }
        public string IDtappa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sequenza> sequenzas { get; set; }
    }
}
