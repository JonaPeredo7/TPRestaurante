using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TPRestaurante.Models;

namespace TPRestaurante.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult MostrarMenu()
        {
            List<MenusCLS> listaMenu;

            using (var db = new Restaurante())
            {
                listaMenu = db.Menus
                    .Where(e => e.HABILITADO == 1)
                    .Select(menu => new MenusCLS
                    {
                        MenuID = menu.MenuID,
                        NombrePlato = menu.NombrePlato,
                        Descripcion = menu.Descripcion,
                        Precio = menu.Precio,
                        Urlimagen = menu.Urlimagen,
                        Categoria = menu.Categoria,
                    })
                    .ToList();
            }

            return View(listaMenu);
        }

        public ActionResult MostrarCarrito()
        {
            // Obtener el carrito desde la sesión
            CarritoCLS carrito = ObtenerCarritoDesdeSesion();

            return View(carrito);
        }

        [HttpPost]
        public ActionResult AgregarAlCarrito(int menuId, int cantidad)
        {
            // Obtener el carrito desde la sesión
            CarritoCLS carrito = ObtenerCarritoDesdeSesion();

            // Buscar el producto en el menú
            MenusCLS producto = ObtenerProductoDesdeMenu(menuId);

            // Verificar si el producto ya está en el carrito
            DetalleCarritoCLS detalleExistente = carrito.Detalles.FirstOrDefault(item => item.MenuID == menuId);

            if (detalleExistente != null)
            {
                // Si el producto ya está en el carrito, aumentar la cantidad
                detalleExistente.Cantidad += cantidad;
            }
            else
            {
                // Si el producto no está en el carrito, agregarlo
                carrito.Detalles.Add(new DetalleCarritoCLS
                {
                    MenuID = producto.MenuID,
                    NombrePlato = producto.NombrePlato,
                    Precio = (int)producto.Precio,
                    Cantidad = cantidad,
                });
            }

            // Guardar el carrito en la sesión
            GuardarCarritoEnSesion(carrito);

            // Redirigir a la vista del carrito
            return RedirectToAction("MostrarCarrito");
        }

        public ActionResult EliminarDelCarrito(int menuId)
        {
            // Obtener el carrito desde la sesión
            CarritoCLS carrito = ObtenerCarritoDesdeSesion();

            // Buscar el detalle del menú en el carrito
            DetalleCarritoCLS detalle = carrito.Detalles.FirstOrDefault(d => d.MenuID == menuId);

            // Verificar si se encontró el detalle
            if (detalle != null)
            {
                // Si la cantidad es mayor a 1, reducir la cantidad; de lo contrario, eliminar el detalle
                if (detalle.Cantidad > 1)
                {
                    detalle.Cantidad--;
                }
                else
                {
                    carrito.Detalles.Remove(detalle);
                }
            }

            // Guardar los elementos actualizados del carrito en la sesión
            GuardarCarritoEnSesion(carrito);

            // Redirigir a la vista del carrito
            return RedirectToAction("MostrarCarrito");
        }


        // Otras funciones del controlador

        private CarritoCLS ObtenerCarritoDesdeSesion()
        {
            if (Session["Carrito"] == null)
            {
                Session["Carrito"] = new CarritoCLS { Detalles = new List<DetalleCarritoCLS>() };
            }

            return (CarritoCLS)Session["Carrito"];
        }

        private void GuardarCarritoEnSesion(CarritoCLS carrito)
        {
            // Lógica para guardar el carrito en la sesión
            Session["Carrito"] = carrito;
        }

        private MenusCLS ObtenerProductoDesdeMenu(int menuId)
        {
            // Lógica para obtener el producto desde la base de datos
            using (var db = new Restaurante())
            {
                return db.Menus
                    .Where(e => e.HABILITADO == 1 && e.MenuID == menuId)
                    .Select(menu => new MenusCLS
                    {
                        MenuID = menu.MenuID,
                        NombrePlato = menu.NombrePlato,
                        Precio = menu.Precio
                        // Otras propiedades que necesites
                    })
                    .FirstOrDefault();
            }
        }
    }
}
