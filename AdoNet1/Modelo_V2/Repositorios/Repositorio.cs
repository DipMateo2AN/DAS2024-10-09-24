using Microsoft.Data.SqlClient;
using Modelo;
using System.Collections.ObjectModel;

namespace Modelo_V2.Repositorios
{
    public abstract class Repositorio<T> : ICrud<T> where T : class
    {
        private readonly List<T> list;
        protected readonly SqlConnection connection;

        public Repositorio()
        {
            list = [];
            connection = new SqlConnection(ConnectionString.GetConnectionString());
        }

        public virtual bool Agregar(T entidad)
        {
            list.Add(entidad);
            return true;
        }

        public virtual bool Eliminar(T entidad)
        {
            return list.Remove(entidad);
        }

        public ReadOnlyCollection<T> Listar()
        {
            return list.AsReadOnly();
        }

        public abstract bool Modificar(T entidad);

        protected abstract void Recuperar();
    }
}
