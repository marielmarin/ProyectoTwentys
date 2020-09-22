using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTwentys.DataAccess
{
    public class PD_GastosVarios
    {

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tablaReportes = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarGastosVarios"; //PROCEDIMIENTO ALMACENADO
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


        public void Insertar(string descripcion, DateTime fecha, double monto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarGastosVarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public void Actualizar(int idGastosVarios, string descripcion, DateTime fecha, double monto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarGastosVarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idGastosVarios", idGastosVarios);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }


        public void Eliminar(int idGastosVarios)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarGastosVarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idGastosVarios", idGastosVarios);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public DataTable Buscar(string descripcion)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarGastosVarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarGastosVariosPorFecha(DateTime fechaInicio, DateTime fechaFinal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarGastosVariosPorFecha";
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

        public DataTable ReporteGastosVariosPorDescripcion(string descripcion)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteGastosVariosPorDescripcion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tablaReportes.Load(leer);
            conexion.CerrarConexion();

            return tablaReportes;
        }

        public DataTable ReporteGastosVariosPorFecha(DateTime fechaInicio, DateTime fechaFinal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteGastosVariosPorFecha";
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
