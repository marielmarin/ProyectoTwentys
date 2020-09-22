using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTwentys.DataAccess
{
    public class PD_GastosExtraordinarios
    {

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tablaReportes = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarGastosExtraordinarios"; //PROCEDIMIENTO ALMACENADO
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


        public void Insertar(string descripcion, double monto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarGastosExtraordinarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public void Actualizar(int idGastosExtraordinarios, string descripcion, double monto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarGastosExtraordinarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idGastosExtraordinarios", idGastosExtraordinarios);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }


        public void Eliminar(int idGastosExtraordinarios)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarGastosExtraordinarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idGastosExtraordinarios", idGastosExtraordinarios);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public DataTable Buscar(string descripcion)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarGastosExtraordinarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable ReportesGastosExtraordinarios(string descripcion)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReportesGastosExtraordinarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tablaReportes.Load(leer);
            conexion.CerrarConexion();

            return tablaReportes;
        }


    }
}
