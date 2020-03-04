using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Almacen.Web.Models
{
    public class Producto
    {

        public int ID { get; set; }

        public int IDCategoria { get; set; }

        public string Nombre
        {
            get; set;
        }

        public decimal Precio { get; set; }

        public decimal Existencia
        {
            get; set;
        }
        [DisplayName("Fecha de ultimo movimiento")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yy}",ApplyFormatInEditMode =true)]
        [DataType(DataType.DateTime)]
        public DateTime UltimoMovimiento
        {
            get;set;
        }

         public virtual Categoria Categoria { get; set; }

    }
}