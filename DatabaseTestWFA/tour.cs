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
    
    public partial class tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tour()
        {
            this.attraziones = new HashSet<attrazione>();
            this.soggiornoes = new HashSet<soggiorno>();
            this.clientes = new HashSet<cliente>();
            this.ristorantes = new HashSet<ristorante>();
        }
    
        public string Destinazione { get; set; }
        public string Nome { get; set; }
        public System.DateTime DataInizio { get; set; }
        public System.DateTime DataFine { get; set; }
        public float Prezzo { get; set; }
        public string IDtour { get; set; }
        public string IDsede { get; set; }
        public string CFtourManager { get; set; }
    
        public virtual dipendente dipendente { get; set; }
        public virtual sede sede { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<attrazione> attraziones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<soggiorno> soggiornoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cliente> clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ristorante> ristorantes { get; set; }
    }
}
