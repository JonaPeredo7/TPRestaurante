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
    
    public partial class Menus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menus()
        {
            this.Clientes = new HashSet<Clientes>();
        }
    
        public int MenuID { get; set; }
        public string NombrePlato { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Categoria { get; set; }
        public Nullable<int> EmpleadoID { get; set; }
        public Nullable<int> HABILITADO { get; set; }
        public string Urlimagen { get; set; }
        public Nullable<int> PedidoID { get; set; }
        public Nullable<int> Stock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual Empleados Empleados { get; set; }
        public virtual Pedidos Pedidos { get; set; }
    }
}
