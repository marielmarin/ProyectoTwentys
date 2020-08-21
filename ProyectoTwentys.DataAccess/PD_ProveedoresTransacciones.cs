using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTwentys.DataAccess
{
    public class PD_ProveedoresTransacciones
    {

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tablaReportes = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProveedorIngreso"; //PROCEDIMIENTO ALMACENADO
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


       public void Insertar(int cedulaJuridica, string descripcion, DateTime fecha, double monto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProveedorTransaccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

       
        public void Actualizar(int idTransaccion, int cedulaJuridica, string descripcion, DateTime fecha, double monto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarProveedorTransaccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idTransaccion", idTransaccion);
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }


        public void Eliminar(int cedulaJuridica, int idTransaccion)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProveedorTransaccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idTransaccion", idTransaccion);
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


      public DataTable Buscar(int cedulaJuridica)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarProveedorTransaccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarPorFechas(DateTime fechaInicio, DateTime fechaFinal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarProveedorPorFecha";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@fechaFinal", fechaFinal);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ReporteProveedorPorCedula(int cedulaJuridica)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteProveedorPorCedula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tablaReportes.Load(leer);
            conexion.CerrarConexion();

            return tablaReportes;
        }

        public DataTable ReporteProveedorPorFecha(DateTime fechaInicio, DateTime fechaFinal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteProveedorPorFecha";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@fechaFinal", fechaFinal);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tablaReportes.Load(leer);
            conexion.CerrarConexion();

            return tablaReportes;
        }
    }
}

