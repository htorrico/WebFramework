//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFramework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class proveedore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public proveedore()
        {
            this.productos = new HashSet<producto>();
        }
    
        public int idProveedor { get; set; }
        public string nombreCompañia { get; set; }
        public string nombrecontacto { get; set; }
        public string cargocontacto { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string region { get; set; }
        public string codPostal { get; set; }
        public string pais { get; set; }
        public string telefono { get; set; }
        public string fax { get; set; }
        public string paginaprincipal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<producto> productos { get; set; }
    }
}