using System.Collections.ObjectModel;

namespace Modelo
{
    internal interface ICrud<T> where T : class
    {
        public bool Agregar(T entidad);
        public abstract bool Modificar(T entidad);
        public bool Eliminar(T entidad);
        public ReadOnlyCollection<T> Listar();
    }
}
