using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPRestaurante.Models
{
    public class ReservasCLS
    {
        public int ReservaID { get; set; }
        public Nullable<int> ClienteID { get; set; }
        public Nullable<System.DateTime> FechaHoraReserva { get; set; }
        public Nullable<int> NumeroPersonas { get; set; }

        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mesas> Mesas { get; set; }
    }
}