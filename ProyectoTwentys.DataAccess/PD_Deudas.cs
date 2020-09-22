using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTwentys.DataAccess
{
    public class PD_Deudas
    {

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tablaReportes = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDeudas"; //PROCEDIMIENTO ALMACENADO
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


        public void Insertar( int idEmpleado, string descripcion,  double monto, string estado)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarDeudas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public void Actualizar(int idDeuda, int idEmpleado, string descripcion, double monto, string estado)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarDeudas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idDeuda", idDeuda);
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }


        public void Eliminar(int idEmpleado, int idDeuda)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDeudas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@idDeuda", idDeuda);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public DataTable Buscar(int idEmpleado)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarDeudas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }    

        public DataTable ReporteDeudasPorEmpleado(int idEmpleado)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteDeudasPorEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tablaReportes.Load(leer);
            conexion.CerrarConexion();

            return tablaReportes;
        }

      
    }
}
