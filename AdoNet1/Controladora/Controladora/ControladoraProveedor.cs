using Modelo_V2.Objetos;
using Modelo_V2.Repositorios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProveedor
    {
        private static readonly Lazy<ControladoraProveedor> instancia = new Lazy<ControladoraProveedor>(()=>new ControladoraProveedor());
        public static ControladoraProveedor Instance=>instancia.Value;

        public ReadOnlyCollection<Proveedor> RecuperarProveedores()
        {
            try
            {
                return RepositorioProveedor.Instance.Listar().AsReadOnly();
            }
            catch(Exception ex)
            {
                return new ReadOnlyCollection<Proveedor>(new List<Proveedor>());
            }
        }
        public bool AgregarProveedor(Proveedor proveedor)
        {
            try
            {
                var proveedorExistente = RepositorioProveedor.Instance.Listar().FirstOrDefault(prov=>prov.Cuit==proveedor.Cuit);
                if (proveedorExistente == null)
                {
                    return RepositorioProveedor.Instance.Agregar(proveedor);
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ModificarProveedor(Proveedor proveedor)
        {
            try
            {
                var proveedorExistente = RepositorioProveedor.Instance.Listar().FirstOrDefault(c => c.Cuit == proveedor.Cuit);
                if (proveedorExistente == null)
                    return RepositorioProveedor.Instance.Modificar(proveedor);
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarProveedor(Proveedor proveedor)
        {
            try
            {
                var proveedorExistente = RepositorioProveedor.Instance.Listar().FirstOrDefault(c => c.Cuit == proveedor.Cuit);
                if (proveedorExistente != null)
                    return RepositorioProveedor.Instance.Eliminar(proveedor);
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
