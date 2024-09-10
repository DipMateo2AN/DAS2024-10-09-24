using Microsoft.Data.SqlClient;
using Modelo_V2.Objetos;

namespace Modelo_V2.Repositorios
{
    public class RepositorioCategorias : Repositorio<Categoria>
    {
        private static readonly Lazy<RepositorioCategorias> _instance = new(() => new RepositorioCategorias());
        public static RepositorioCategorias Instance => _instance.Value;

        private RepositorioCategorias()
        {
            Recuperar();
        }

        public override bool Agregar(Categoria entidad)
        {
            var isOk = false;
            connection.Open();
            var transaction = connection.BeginTransaction();
            try
            {
                using var sqlCommand = new SqlCommand();
                sqlCommand.Transaction = transaction;
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_InsertarCategoria";
                sqlCommand.Parameters.Add("@codigo", System.Data.SqlDbType.NVarChar, 15).Value = entidad.Codigo;
                sqlCommand.Parameters.Add("@descripcion", System.Data.SqlDbType.NVarChar, 150).Value = entidad.Descripcion;
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
                connection.Close();
                base.Agregar(entidad);
                isOk = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                connection.Close();
            }
            return isOk;
        }

        public override bool Modificar(Categoria entidad)
        {
            var isOk = false;
            connection.Open();
            var transaction = connection.BeginTransaction();
            try
            {
                using var sqlCommand = new SqlCommand();
                sqlCommand.Transaction = transaction;
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ModificarCategoria";
                sqlCommand.Parameters.Add("@codigo", System.Data.SqlDbType.NVarChar, 15).Value = entidad.Codigo;
                sqlCommand.Parameters.Add("@descripcion", System.Data.SqlDbType.NVarChar, 150).Value = entidad.Descripcion;
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
                connection.Close();
                isOk = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                connection.Close();
            }
            return isOk;
        }

        protected override void Recuperar()
        {
            connection.Open();
            try
            {
                using var sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_RecuperarCategorias";
                var dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    var categoria = new Categoria
                    {
                        Codigo = dr["Codigo"].ToString(),
                        Descripcion = dr["Descripcion"].ToString()
                    };
                    base.Agregar(categoria);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
            }
        }

        public override bool Eliminar(Categoria entidad)
        {
            var isOk = false;
            connection.Open();
            var transaction = connection.BeginTransaction();
            try
            {
                using var sqlCommand = new SqlCommand();
                sqlCommand.Transaction = transaction;
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_EliminarCategoria";
                sqlCommand.Parameters.Add("@codigo", System.Data.SqlDbType.NVarChar, 15).Value = entidad.Codigo;
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
                connection.Close();
                base.Eliminar(entidad);
                isOk = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                connection.Close();
            }
            return isOk;
        }
    }
}
