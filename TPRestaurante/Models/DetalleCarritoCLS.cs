using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPRestaurante.Models
{
    public class DetalleCarritoCLS
    {
        public int MenuID { get; set; }
        public string NombrePlato { get; set; }
        public string Urlimagen { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get { return Precio * Cantidad; } }
    }
}