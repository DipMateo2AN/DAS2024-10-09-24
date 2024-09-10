using Microsoft.Data.SqlClient;
using Modelo_V2.Objetos;

namespace Modelo_V2.Repositorios
{
    public class RepositorioProductos : Repositorio<Producto>
    {
        private static readonly Lazy<RepositorioProductos> instance = new(() => new RepositorioProductos());
        public static RepositorioProductos Instance => instance.Value;

        private RepositorioProductos()
        {
            Recuperar();
        }

        public override bool Agregar(Producto entidad)
        {
            var isOk = false;
            //abrimos la conexión
            connection.Open();
            //iniciamos la transacción
            var transaction = connection.BeginTransaction();
            try
            {
                //creamos el comando para ejecutar el procedimiento almacenado de inserción
                using var sqlCommand = new SqlCommand();
                //asignamos la transacción y la conexión al comando
                sqlCommand.Transaction = transaction;
                sqlCommand.Connection = connection;
                //especificamos que el comando es de tipo procedimiento almacenado
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //especificamos el nombre del procedimiento almacenado
                sqlCommand.CommandText = "sp_InsertarProducto";
                //agregamos los parámetros necesarios para la ejecución del procedimiento almacenado
                sqlCommand.Parameters.Add("@codigo", System.Data.SqlDbType.NVarChar, 15).Value = entidad.Codigo;
                sqlCommand.Parameters.Add("@descripcion", System.Data.SqlDbType.NVarChar, 150).Value = entidad.Descripcion;
                sqlCommand.Parameters.Add("@precioVenta", System.Data.SqlDbType.Decimal).Value = entidad.PrecioVenta;
                sqlCommand.Parameters.Add("@precioCompra", System.Data.SqlDbType.Decimal).Value = entidad.PrecioCompra;
                sqlCommand.Parameters.Add("@CantidadActual", System.Data.SqlDbType.Int).Value = entidad.CantidadActual;
                sqlCommand.Parameters.Add("@CantidadMinima", System.Data.SqlDbType.Int).Value = entidad.CantidadMinima;
                sqlCommand.Parameters.Add("@CodigoCategoria", System.Data.SqlDbType.NVarChar, 15).Value = entidad.Categoria.Codigo;
                sqlCommand.Parameters.Add("@CuitProveedor", System.Data.SqlDbType.Int).Value = entidad.Proveedor.Cuit;
                //ejecutamos el comando
                sqlCommand.ExecuteNonQuery();
                //confirmamos la transacción
                transaction.Commit();
                //cerramos la conexión
                connection.Close();
                isOk = true;
            }
            catch (Exception ex)
            {
                //en caso de error, deshacemos la transacción y cerramos la conexión
                Console.WriteLine(ex.ToString());
                transaction.Rollback();
                connection.Close();
            }
            return isOk;
        }

        public override bool Modificar(Producto entidad)
        {
            var isOk = false;
            //abrimos la conexión
            connection.Open();
            //iniciamos la transacción
            var transaction = connection.BeginTransaction();
            try
            {
                //creamos el comando para ejecutar el procedimiento almacenado de actualización
                using var sqlCommand = new SqlCommand();
                //asignamos la transacción y la conexión al comando
                sqlCommand.Transaction = transaction;
                sqlCommand.Connection = connection;
                //especificamos que el comando es de tipo procedimiento almacenado
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //especificamos el nombre del procedimiento almacenado
                sqlCommand.CommandText = "sp_ActualizarProducto";
                //agregamos los parámetros necesarios para la ejecución del procedimiento almacenado
                sqlCommand.Parameters.Add("@codigo", System.Data.SqlDbType.NVarChar, 15).Value = entidad.Codigo;
                sqlCommand.Parameters.Add("@descripcion", System.Data.SqlDbType.NVarChar, 150).Value = entidad.Descripcion;
                sqlCommand.Parameters.Add("@precioVenta", System.Data.SqlDbType.Decimal).Value = entidad.PrecioVenta;
                sqlCommand.Parameters.Add("@precioCompra", System.Data.SqlDbType.Decimal).Value = entidad.PrecioCompra;
                sqlCommand.Parameters.Add("@CantidadActual", System.Data.SqlDbType.Int).Value = entidad.CantidadActual;
                sqlCommand.Parameters.Add("@CantidadMinima", System.Data.SqlDbType.Int).Value = entidad.CantidadMinima;
                sqlCommand.Parameters.Add("@CodigoCategoria", System.Data.SqlDbType.NVarChar, 15).Value = entidad.Categoria.Codigo;
                sqlCommand.Parameters.Add("@CuitProveedor", System.Data.SqlDbType.Int).Value = entidad.Proveedor.Cuit;
                //ejecutamos el comando
                sqlCommand.ExecuteNonQuery();
                //confirmamos la transacción
                transaction.Commit();
                //cerramos la conexión
                connection.Close();
                isOk = true;
            }
            catch (Exception ex)
            {
                //en caso de error, deshacemos la transacción y cerramos la conexión
                transaction.Rollback();
                connection.Close();
            }
            return isOk;
        }

        protected override void Recuperar()
        {
            try
            {
                //abrimos la conexión
                connection.Open();
                //creamos el comando para ejecutar el procedimiento almacenado de recuperación
                using var sqlCommand = new SqlCommand();
                //asignamos la conexión al comando
                sqlCommand.Connection = connection;
                //especificamos que el comando es de tipo procedimiento almacenado
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //especificamos el nombre del procedimiento almacenado
                sqlCommand.CommandText = "sp_RecuperarProductos";
                //ejecutamos el comando
                var dr = sqlCommand.ExecuteReader();
                //recorremos el datareader y agregamos los productos a la lista
                while (dr.Read())
                {
                    //creamos un nuevo producto
                    var producto = new Producto
                    {
                        Codigo = dr["Codigo"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                        PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                        CantidadActual = Convert.ToInt32(dr["CantidadActual"]),
                        CantidadMinima = Convert.ToInt32(dr["CantidadMinima"]),
                        //buscamos la categoría en la lista de categorías y la asignamos al producto usando como criterio de búsqueda el código de la categoría
                        Categoria = RepositorioCategorias.Instance.Listar().FirstOrDefault(categoria => categoria.Codigo == dr["CodigoCategoria"].ToString()),
                        Proveedor = RepositorioProveedor.Instance.Listar().FirstOrDefault(proveedor => proveedor.Cuit.ToString() == dr["CuitProveedor"].ToString())
                    };
                    base.Agregar(producto);
                }
                //cerramos el datareader
                //cerramos la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                //en caso de error, cerramos la conexión
                connection.Close();
            }
        }

        public override bool Eliminar(Producto entidad)
        {
            var isOk = false;
            //abrimos la conexión
            connection.Open();
            //iniciamos la transacción
            var transaction = connection.BeginTransaction();
            try
            {
                //creamos el comando para ejecutar el procedimiento almacenado de eliminación
                using var sqlCommand = new SqlCommand();
                //asignamos la transacción y la conexión al comando
                sqlCommand.Transaction = transaction;
                sqlCommand.Connection = connection;
                //especificamos que el comando es de tipo procedimiento almacenado
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //especificamos el nombre del procedimiento almacenado
                sqlCommand.CommandText = "sp_EliminarProducto";
                //agregamos los parámetros necesarios para la ejecución del procedimiento almacenado
                sqlCommand.Parameters.Add("@Codigo", System.Data.SqlDbType.NVarChar, 15).Value = entidad.Codigo;
                //ejecutamos el comando
                sqlCommand.ExecuteNonQuery();
                //confirmamos la transacción
                transaction.Commit();
                //cerramos la conexión
                connection.Close();
                //eliminamos el producto de la lista
                base.Eliminar(entidad);
                isOk = true;
            }
            catch (Exception ex)
            {
                //en caso de error, deshacemos la transacción y cerramos la conexión
                transaction.Rollback();
                connection.Close();
            }
            return isOk;
        }
    }
}
