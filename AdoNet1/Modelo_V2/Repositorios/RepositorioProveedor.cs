using Microsoft.Data.SqlClient;
using Modelo_V2.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_V2.Repositorios
{
    public class RepositorioProveedor : Repositorio<Proveedor>
    {
        private static readonly Lazy<RepositorioProveedor> instancia = new Lazy<RepositorioProveedor>(()=>new RepositorioProveedor());
        public static RepositorioProveedor Instance=> instancia.Value;

        private RepositorioProveedor()
        {
            Recuperar();
        }

        protected override void Recuperar()
        {
            try
            {
                connection.Open();
                using var sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_RecuperarProveedores";
                var dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Proveedor proveedor = new Proveedor();
                    proveedor.Cuit = int.Parse(dr["Cuit"].ToString());
                    proveedor.RazonSocial = dr["RazonSocial"].ToString();
                    proveedor.Telefono = int.Parse(dr["Telefono"].ToString());
                    proveedor.Direccion = dr["Direccion"].ToString();

                    base.Agregar(proveedor);
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
            }
        }

        public override bool Agregar(Proveedor proveedor)
        {
            var incersion = false;
            connection.Open();
            var transaction = connection.BeginTransaction();

            try
            {
                using SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Transaction = transaction;
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_AgregarProveedor";
                sqlCommand.Parameters.Add("@Cuit",System.Data.SqlDbType.Int,15).Value=proveedor.Cuit;
                sqlCommand.Parameters.Add("@RazonSocial",System.Data.SqlDbType.NVarChar,15).Value=proveedor.RazonSocial;
                sqlCommand.Parameters.Add("@Telefono",System.Data.SqlDbType.Int,15).Value=proveedor.Telefono;
                sqlCommand.Parameters.Add("@Direccion",System.Data.SqlDbType.NVarChar,15).Value=proveedor.Direccion;
                sqlCommand.ExecuteNonQuery();

                transaction.Commit();
                connection.Close();
                base.Agregar(proveedor);
                incersion = true;
            }
            catch
            {
                transaction.Rollback();
                connection.Close();
            }
            return incersion;
        }

        public override bool Modificar(Proveedor entidad)
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
                sqlCommand.CommandText = "sp_ModificarProveedor";
                //agregamos los parámetros necesarios para la ejecución del procedimiento almacenado
                sqlCommand.Parameters.Add("@Cuit", System.Data.SqlDbType.Int, 15).Value = entidad.Cuit;
                sqlCommand.Parameters.Add("@RazonSocial", System.Data.SqlDbType.NVarChar, 15).Value = entidad.RazonSocial;
                sqlCommand.Parameters.Add("@Telefono", System.Data.SqlDbType.Int, 15).Value = entidad.Telefono;
                sqlCommand.Parameters.Add("@Direccion", System.Data.SqlDbType.NVarChar, 15).Value = entidad.Direccion;
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

        public override bool Eliminar(Proveedor entidad)
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
                sqlCommand.CommandText = "sp_EliminarProveedor";
                //agregamos los parámetros necesarios para la ejecución del procedimiento almacenado
                sqlCommand.Parameters.Add("@Cuit", System.Data.SqlDbType.NVarChar, 15).Value = entidad.Cuit;
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
