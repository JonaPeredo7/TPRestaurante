using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPRestaurante.Models
{
    public class TransaccionesCLS
    {
        public int TransaccionID { get; set; }
        public string TipoTransaccion { get; set; }
        public Nullable<System.DateTime> FechaHoraTransaccion { get; set; }
        public Nullable<decimal> Monto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}