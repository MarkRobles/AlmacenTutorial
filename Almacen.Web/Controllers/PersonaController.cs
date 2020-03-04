using Almacen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almacen.Web.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Persona datos)
        {
            ActionResult Resultado;

            if (ModelState.IsValid)
            {
                Resultado = Content("Datos Correctos");
            }
            else
            {
                Resultado = View(datos);
            }
            return Resultado;
        }

    }
}