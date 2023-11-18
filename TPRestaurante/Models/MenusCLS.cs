using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPRestaurante.Models
{
    public class MenusCLS
    {
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