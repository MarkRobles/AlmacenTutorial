using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Almacen.Web.Models
{
    public class Categoria
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public virtual string Descripcion { get; set; }

        public virtual IEnumerable<Producto> Productos { get; set; }

    }
}