using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_V2.Objetos
{
    public class Producto
    {
        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal PrecioCompra { get; set; }

        public decimal PrecioVenta { get; set; }

        public int CantidadActual { get; set; }

        public int CantidadMinima { get; set; }

        public Categoria Categoria { get; set; }

        public Proveedor Proveedor { get; set; }
    }
}
