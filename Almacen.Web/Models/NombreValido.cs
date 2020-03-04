using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Almacen.Web.Models
{

    /*
     ValidationAttribute es una clase abastracta que expone varios metodos es la clase base de los validadores*/
    public class NombreValido: ValidationAttribute
    {


        private bool VerificarNombre(string nombre)
        {
            /*Logica de acceso a base de datos para buscar si ya existe el nombre de usuario*/

            /**Si el usuario esta proporcionando u ocasionando un error*/
            if (this.ErrorMessage.Contains("{0}"))
            {
                /*Reemplazarlo por el nombre que se encontro en la base de datos*/
                this.ErrorMessage = this.ErrorMessage.Replace("{0}", "Demo");

            }

            return nombre != "Demo";
        }

        /*Sobreeescribir el metodo is ValidationAttribute*/
        public override bool IsValid(object value)
        {


            return VerificarNombre(value.ToString());
        }



    }
}
 