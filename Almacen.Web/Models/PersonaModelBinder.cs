using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almacen.Web.Models
{
    public class PersonaModelBinder : IModelBinder
    {

        /*El primer parametro proporciona informacion acerca del controlador y su informacion asociada, el segundo parametro proporciona metadata  del modelo*/
        public object BindModel(
            ControllerContext controllerContext,
            ModelBindingContext bindingContext)
        {
            var Request = controllerContext.HttpContext.Request;

            var Persona = new Persona();
            Persona.Nombre = Request.Form["Nombre"];
            Persona.CodigoPostal = Request.Form["CodigoPostal"];
            Persona.DominioIngles = byte.Parse( Request.Form["DominioIngles"]);
            Persona.Correo = Request.Form["Correo"];

            Persona.Habilidades =  Request.Form["Habilidades"].Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries).
                Select(h =>h.Trim()).ToArray();

            if (Persona.Habilidades.Count() <= 1)
            {
                bindingContext.ModelState.AddModelError("Habilidades","Debe proporcionar mas de una habilidad");
            }
            return Persona;
        }
    }
}