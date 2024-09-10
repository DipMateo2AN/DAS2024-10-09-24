using Modelo_V2.Objetos;
using Modelo_V2.Repositorios;
using System.Collections.ObjectModel;

namespace Controladora
{
    public class ControladoraProductos
    {
        private static readonly Lazy<ControladoraProductos> instancia = new(() => new ControladoraProductos());

       
        private ControladoraProductos()
        {
            // Private constructor prevents direct instantiation
        }

        public static ControladoraProductos Instancia => instancia.Value;

        public ReadOnlyCollection<Producto> RecuperarProductos()
        {
            try
            {
                return RepositorioProductos.Instance.Listar().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Producto>(new List<Producto>());
            }

        }

        public ReadOnlyCollection<Categoria> RecuperarCategorias()
        {
            try
            {
                return RepositorioCategorias.Instance.Listar().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Categoria>(new List<Categoria>());
            }

        }

        public ReadOnlyCollection<Proveedor> RecuperarProveedor()
        {
            try
            {
                return RepositorioProveedor.Instance.Listar().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Proveedor>(new List<Proveedor>());
            }

        }

        public bool AgregarProducto(Producto producto)
        {
            try
            {
                var productoExistente = RepositorioProductos.Instance.Listar().FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (productoExistente == null)
                    return RepositorioProductos.Instance.Agregar(producto);
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public bool ModificarProducto(Producto producto)
        {
            try
            {
                var productoExistente = RepositorioProductos.Instance.Listar().FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (productoExistente != null)
                    return RepositorioProductos.Instance.Modificar(producto);
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarProducto(Producto producto)
        {
            try
            {
                var productoExistente = RepositorioProductos.Instance.Listar().FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (productoExistente != null)
                    return RepositorioProductos.Instance.Eliminar(producto);
                else return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
