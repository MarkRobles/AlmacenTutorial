using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almacen.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            Models.Categoria c = new Models.Categoria
            {
                ID = 1,
                Nombre = "Bebidas",
                Descripcion = " Categoria de productos liquidos"
            };
            return View(c);
        }
    }
}