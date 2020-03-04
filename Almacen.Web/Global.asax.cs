using Almacen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Almacen.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            /*Agregar al runtime de MVC el enlazador de model personalizado que creamos*/
            ModelBinders.Binders.Add(typeof(Persona), new PersonaModelBinder());
        }
    }
}
