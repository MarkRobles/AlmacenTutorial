using Almacen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almacen.Web.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            Producto p = new Producto
            {
                ID = 5,
                Nombre = "Leche",
                IDCategoria = 1,
                Existencia = 100,
                Precio = 15,
                UltimoMovimiento = new DateTime(2013, 01, 25)
            };
            return View(p);
        }
    }
}