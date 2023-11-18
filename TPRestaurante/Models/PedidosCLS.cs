using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPRestaurante.Models
{
    public class PedidosCLS
    {
        public int PedidoID { get; set; }
        public Nullable<int> ClienteID { get; set; }
        public Nullable<System.DateTime> FechaHoraPedido { get; set; }
        public string EstadoPedido { get; set; }
        public Nullable<int> Cantidad { get; set; }

        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menus> Menus { get; set; }
    }
}