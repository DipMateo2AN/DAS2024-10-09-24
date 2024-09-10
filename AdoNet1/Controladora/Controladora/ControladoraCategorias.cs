using Modelo_V2.Objetos;
using Modelo_V2.Repositorios;
using System.Collections.ObjectModel;

namespace Controladora
{
    public sealed class ControladoraCategorias // La clase es sealed para que no se pueda heredar de la misma y crear nuevos objetos
    {
        private static readonly Lazy<ControladoraCategorias> instancia = new(() => new ControladoraCategorias());
        
        //otra forma de declarar el atributo
        //private static readonly Lazy<ControladoraCategorias> singleInstance = new Lazy<ControladoraCategorias>(() => new ControladoraCategorias());
        
        private ControladoraCategorias()
        {
            // Private constructor prevents direct instantiation
        }

        public static ControladoraCategorias Instancia => instancia.Value;

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

        public bool AgregarCategoria(Categoria categoria)
        {
            try
            {
                var categoriaExistente = RepositorioCategorias.Instance.Listar().FirstOrDefault(c => c.Codigo == categoria.Codigo);
                if (categoriaExistente == null)
                    return RepositorioCategorias.Instance.Agregar(categoria);
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public bool ModificarCategoria(Categoria categoria)
        {
            try
            {
                var categoriaExistente = RepositorioCategorias.Instance.Listar().FirstOrDefault(c => c.Codigo == categoria.Codigo);
                if (categoriaExistente != null)
                    return RepositorioCategorias.Instance.Modificar(categoria);
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarCategoria(Categoria categoria)
        {
            try
            {
                //verifico si la categoria esta asignada a algun producto
                var categoriaAsignada = RepositorioProductos.Instance.Listar().FirstOrDefault(p => p.Categoria.Codigo == categoria.Codigo);
                if (categoriaAsignada != null)
                    return false;
                //verifico si la categoria existe
                var categoriaExistente = RepositorioCategorias.Instance.Listar().FirstOrDefault(c => c.Codigo == categoria.Codigo);
                if (categoriaExistente != null)
                    return RepositorioCategorias.Instance.Eliminar(categoria);
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }

    //public class ChildClass : ControladoraCategorias { }
    // si se descomenta se visualiza el error de que no se puede heredar de una clases sealed
}
