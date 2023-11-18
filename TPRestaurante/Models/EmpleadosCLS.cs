using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPRestaurante.Models
{
    public class EmpleadosCLS
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Nullable<int> UsuarioID { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}