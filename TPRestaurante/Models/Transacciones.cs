//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPRestaurante.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transacciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transacciones()
        {
            this.Clientes = new HashSet<Clientes>();
        }
    
        public int TransaccionID { get; set; }
        public string TipoTransaccion { get; set; }
        public Nullable<System.DateTime> FechaHoraTransaccion { get; set; }
        public Nullable<decimal> Monto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}