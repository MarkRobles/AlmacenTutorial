using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Almacen.Web.Models
{
    public class Persona
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Debe proporcionar un nombre")]
        [NombreValido(ErrorMessage ="El nombre {0} ya existe")]
        public string Nombre { get; set; }

        [StringLength(5, MinimumLength = 5,ErrorMessage ="El codigo postal debe ser de 5 caracteres")]
        [DisplayName("Codigo Postal")]
        public string CodigoPostal { get; set; }

        [Range(0,100,ErrorMessage ="El rango es de 0 a 100")]
        [DisplayName("Dominio del idioma ingles")]
        public byte DominioIngles { get; set; }

        [Required(ErrorMessage ="El correo es requerido")]
        [RegularExpression(@".+\@.+\..+",ErrorMessage ="No cumple el formato correcto de un correo...")]
        public string Correo { get; set; }

        [Required]
        public string[]     Habilidades { get; set; }



    }
}