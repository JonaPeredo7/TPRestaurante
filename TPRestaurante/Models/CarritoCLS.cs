using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPRestaurante.Models
{
    public class CarritoCLS
    {
        public List<DetalleCarritoCLS> Detalles { get; set; }

        public decimal Total
        {
            get { return Detalles.Sum(detalle => detalle.Total); }
        }
    }
}