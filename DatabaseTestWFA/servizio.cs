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
    
    public partial class servizio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public servizio()
        {
            this.accessorios = new HashSet<accessorio>();
            this.biciclettas = new HashSet<bicicletta>();
            this.dipendentes = new HashSet<dipendente>();
        }
    
        public System.DateTime DataInizio { get; set; }
        public System.DateTime DataFine { get; set; }
        public float CostoGiornaliero { get; set; }
        public string IDservizio { get; set; }
        public string tipoServizio { get; set; }
        public string IDpacchetto { get; set; }
        public string IDsede { get; set; }
        public string IDpercorso { get; set; }
    
        public virtual pacchetto pacchetto { get; set; }
        public virtual percorso percorso { get; set; }
        public virtual sede sede { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<accessorio> accessorios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bicicletta> biciclettas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dipendente> dipendentes { get; set; }
    }
}
