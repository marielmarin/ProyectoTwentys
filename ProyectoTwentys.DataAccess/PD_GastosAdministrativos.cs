using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProyectoTwentys.DataAccess
{
    public class PD_GastosAdministrativos
    {

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tablaReportes = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarGastosAdministrativos"; //PROCEDIMIENTO ALMACENADO
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


        public void Insertar(string descripcion, DateTime fecha, double monto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarGastosAdministrativos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public void Actualizar(int idGastosAdministrativos, string descripcion, DateTime fecha, double monto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarGastosAdministrativos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idGastosAdministrativos", idGastosAdministrativos);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }


        public void Eliminar(int idGastosAdministrativos)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarGastosAdministrativos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idGastosAdministrativos", idGastosAdministrativos);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public DataTable Buscar(string descripcion)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarGastosAdministrativos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarGastosAdministrativosPorFecha(DateTime fechaInicio, DateTime fechaFinal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarGastosAdministrativosPorFecha";
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

        public DataTable ReporteGastosAdministrativosPorDescripcion(string descripcion)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteGastosAdministrativosPorDescripcion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tablaReportes.Load(leer);
            conexion.CerrarConexion();

            return tablaReportes;
        }

        public DataTable ReporteGastosAdministrativosPorFecha(DateTime fechaInicio, DateTime fechaFinal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteGastosAdministrativosPorFecha";
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
