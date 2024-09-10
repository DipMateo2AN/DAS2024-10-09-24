using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace Modelo
{
    public class RepositorioProductos
    {
        private readonly List<Producto> productos;
        private readonly SqlConnection connection;
        private RepositorioProductos()
        {
            productos = [];
            var connectionString = ConnectionString.GetConnectionString();
            connection = new SqlConnection(connectionString);
            Recuperar();
        }

        // Step 2: Create a private static readonly variable to hold the Lazy instance of the class
        private static readonly Lazy<RepositorioProductos> instance = new(() => new RepositorioProductos());

        // Step 3: Provide a public static method to get the instance of the class
        public static RepositorioProductos Instance => instance.Value;

        public bool Agregar(Producto producto)
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
                sqlCommand.CommandText = "sp_InsertarProducto";
                sqlCommand.Parameters.Add("@codigo", System.Data.SqlDbType.NVarChar, 15).Value = producto.Codigo;
                sqlCommand.Parameters.Add("@descripcion", System.Data.SqlDbType.NVarChar, 150).Value = producto.Descripcion;
                sqlCommand.Parameters.Add("@precioVenta", System.Data.SqlDbType.Decimal).Value = producto.PrecioVenta;
                sqlCommand.Parameters.Add("@precioCompra", System.Data.SqlDbType.Decimal).Value = producto.PrecioCompra;
                sqlCommand.Parameters.Add("@CantidadActual", System.Data.SqlDbType.Int).Value = producto.CantidadActual;
                sqlCommand.Parameters.Add("@CantidadMinima", System.Data.SqlDbType.Int).Value = producto.CantidadMinima;
                sqlCommand.Parameters.Add("@CodigoCategoria", System.Data.SqlDbType.NVarChar, 15).Value = producto.Categoria.Codigo;
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
                connection.Close();

                productos.Add(producto);
                estaInsertado = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                connection.Close();
            }
            return estaInsertado;
        }

        public bool Eliminar(Producto producto)
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
                sqlCommand.CommandText = "sp_EliminarProducto";
                sqlCommand.Parameters.Add("@Codigo", System.Data.SqlDbType.NVarChar, 15).Value = producto.Codigo;
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
                connection.Close();

                productos.Remove(producto);
                estaEliminado = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                connection.Close();
            }
            return estaEliminado;
        }

        public bool Modificar(Producto producto)
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
                sqlCommand.CommandText = "sp_ActualizarProducto";
                sqlCommand.Parameters.Add("@codigo", System.Data.SqlDbType.NVarChar, 15).Value = producto.Codigo;
                sqlCommand.Parameters.Add("@descripcion", System.Data.SqlDbType.NVarChar, 150).Value = producto.Descripcion;
                sqlCommand.Parameters.Add("@precioVenta", System.Data.SqlDbType.Decimal).Value = producto.PrecioVenta;
                sqlCommand.Parameters.Add("@precioCompra", System.Data.SqlDbType.Decimal).Value = producto.PrecioCompra;
                sqlCommand.Parameters.Add("@CantidadActual", System.Data.SqlDbType.Int).Value = producto.CantidadActual;
                sqlCommand.Parameters.Add("@CantidadMinima", System.Data.SqlDbType.Int).Value = producto.CantidadMinima;
                sqlCommand.Parameters.Add("@CodigoCategoria", System.Data.SqlDbType.NVarChar, 15).Value = producto.Categoria.Codigo;
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
                connection.Close();

                productos.Remove(producto);
                productos.Add(producto);
                estaModificado = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                connection.Close();
            }
            return estaModificado;
        }

        public ReadOnlyCollection<Producto> Listar()
        {
            return productos.AsReadOnly();
        }

        private void Recuperar()
        {
            connection.Open();
            try
            {
                using var sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_RecuperarProductos";
                var dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    var producto = new Producto
                    {
                        Codigo = dr["Codigo"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                        PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                        CantidadActual = Convert.ToInt32(dr["CantidadActual"]),
                        CantidadMinima = Convert.ToInt32(dr["CantidadMinima"]),
                        Categoria = RepositorioCategorias.Instance.Listar().FirstOrDefault(categoria => categoria.Codigo == dr["CodigoCategoria"].ToString())
                    };
                    productos.Add(producto);
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
