using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoTwentys.DataAccess
{
    public class PD_Vales
    {

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tablaReportes = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarVales"; //PROCEDIMIENTO ALMACENADO
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


        public void Insertar(int idCuentasPorCobrar, string descripcion, DateTime fecha, double monto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarVales";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCuentasPorCobrar", idCuentasPorCobrar);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public void Actualizar(int idCuentasPorCobrar, int idVales, string descripcion, DateTime fecha, double monto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarVales";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idVales", idVales);
            comando.Parameters.AddWithValue("@idCuentasPorCobrar", idCuentasPorCobrar);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }


        public void Eliminar(int idVales, int idCuentasPorCobrar)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarVales";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idVales", idVales);
            comando.Parameters.AddWithValue("@idCuentasPorCobrar", idCuentasPorCobrar);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public DataTable Buscar(int idCuentasPorCobrar)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarVales";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCuentasPorCobrar", idCuentasPorCobrar);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarValesPorFecha(DateTime fechaInicio, DateTime fechaFinal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarValesPorFecha";
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

        public DataTable ReporteValesPorCuentasPorCobrar(int idCuentasPorCobrar)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteValesPorCuentasPorCobrar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCuentasPorCobrar", idCuentasPorCobrar);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tablaReportes.Load(leer);
            conexion.CerrarConexion();

            return tablaReportes;
        }

        public DataTable ReporteValesPorFecha(DateTime fechaInicio, DateTime fechaFinal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteValesPorFecha";
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
