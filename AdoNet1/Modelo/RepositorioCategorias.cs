using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace Modelo
{
    public class RepositorioCategorias 
    {
        private readonly List<Categoria> categorias;
        private readonly SqlConnection connection;
        private RepositorioCategorias()
        {
            categorias = [];
            var connectionString = ConnectionString.GetConnectionString();
            connection = new SqlConnection(connectionString);
            Recuperar();
        }
        
        // Step 2: Create a private static readonly variable to hold the Lazy instance of the class
        private static readonly Lazy<RepositorioCategorias> _instance = new(() => new RepositorioCategorias());
              
        // Step 3: Provide a public static method to get the instance of the class
        public static RepositorioCategorias Instance => _instance.Value;

        public bool Agregar(Categoria categoria)
        {
            var estaInsertado = false;
            connection.Open();
            var transaction = connection.BeginTransaction();
            try 
            {
                using var sqlCommand = new SqlCommand();
                sqlCommand.Transaction = transaction;
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_InsertarCategoria";
                sqlCommand.Parameters.Add("@codigo", System.Data.SqlDbType.NVarChar,15).Value = categoria.Codigo;
                sqlCommand.Parameters.Add("@descripcion", System.Data.SqlDbType.NVarChar, 150).Value = categoria.Descripcion;
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
                connection.Close();

                categorias.Add(categoria);
                estaInsertado = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                connection.Close();
            }
            return estaInsertado;
        }
        
        public bool Eliminar(Categoria categoria)
        {
            var estaEliminado = false;
            connection.Open();
            var transaction = connection.BeginTransaction();
            try
            {
                using var sqlCommand = new SqlCommand();
                sqlCommand.Transaction = transaction;
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_EliminarCategoria";
                sqlCommand.Parameters.Add("@codigo", System.Data.SqlDbType.NVarChar, 15).Value = categoria.Codigo;
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
                connection.Close();

                categorias.Remove(categoria);
                estaEliminado = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                connection.Close();
            }
            return estaEliminado;
        }

        public bool Modificar(Categoria categoria)
        {
             var estaModificado = false;
            connection.Open();
            var transaction = connection.BeginTransaction();
            try
            {
                using var sqlCommand = new SqlCommand();
                sqlCommand.Transaction = transaction;
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ActualizarCategoria";
                sqlCommand.Parameters.Add("@codigo", System.Data.SqlDbType.NVarChar, 15).Value = categoria.Codigo;
                sqlCommand.Parameters.Add("@descripcion", System.Data.SqlDbType.NVarChar, 150).Value = categoria.Descripcion;
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
                connection.Close();

                categorias.Remove(categoria);
                categorias.Add(categoria);
                estaModificado = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                connection.Close();
            }
            return estaModificado;
        }

        public ReadOnlyCollection<Categoria> Listar()
        {
            return categorias.AsReadOnly();
        }
        
        private void Recuperar()
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
                    categorias.Add(categoria);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
            }
        }
    }
}
