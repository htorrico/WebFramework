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
    
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Pedidos = new HashSet<Pedido>();
        }
    
        public int IdEmpleado { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string cargo { get; set; }
        public string Tratamiento { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<System.DateTime> FechaContratacion { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string region { get; set; }
        public string codPostal { get; set; }
        public string pais { get; set; }
        public string TelDomicilio { get; set; }
        public string Extension { get; set; }
        public string notas { get; set; }
        public Nullable<int> Jefe { get; set; }
        public Nullable<decimal> sueldoBasico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}