using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_V2.Objetos
{
    public class Proveedor
    {
        public int Cuit {get;set;}
        public string RazonSocial { get;set;}
        public int Telefono { get;set;}
        public string Direccion { get;set;}

        public override string ToString()
        {
            return Cuit + " - " + RazonSocial;
        }

    }
}
