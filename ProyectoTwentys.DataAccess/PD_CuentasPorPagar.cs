using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTwentys.DataAccess
{
    public class PD_CuentasPorPagar
    {

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tablaReportes = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCuentasPorPagar"; //PROCEDIMIENTO ALMACENADO
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


       public void Insertar(int cedulaJuridica, string descripcion, DateTime fecha, double monto, string estado)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarCuentasPorPagar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

       
        public void Actualizar(int idCuentasPorPagar, int cedulaJuridica, string descripcion, DateTime fecha, double monto, string estado)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarCuentasPorPagar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCuentasPorPagar", idCuentasPorPagar);
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }


        public void Eliminar(int cedulaJuridica, int idCuentasPorPagar)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCuentasPorPagar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCuentasPorPagar", idCuentasPorPagar);
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


      public DataTable Buscar(int cedulaJuridica)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarCuentasPorPagar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

       
        public DataTable ReporteCuentasPorPagarPorCedula(int cedulaJuridica)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteCuentasPorPagarPorCedula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tablaReportes.Load(leer);
            conexion.CerrarConexion();

            return tablaReportes;
        }

        public DataTable ReporteCuentasPorPagarPorFecha(DateTime fechaInicio, DateTime fechaFinal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteCuentasPorPagarPorFecha";
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

        public DataTable BuscarPorFechas(DateTime fechaInicio, DateTime fechaFinal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarCuentasPorPagarPorFecha";
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

    }
}

