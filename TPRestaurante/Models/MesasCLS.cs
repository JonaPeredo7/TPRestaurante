using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPRestaurante.Models
{
    public class MesasCLS
    {
        public int MesaID { get; set; }
        public Nullable<int> NumeroMesa { get; set; }
        public Nullable<int> CapacidadMaxima { get; set; }
        public string EstadoMesa { get; set; }
        public Nullable<int> ReservaID { get; set; }

        public virtual Reservas Reservas { get; set; }
    }
}