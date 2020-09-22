using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoTwentys.DataAccess
{
    public class PD_Balances
    {

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable ReporteGastosAdministrativos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BalancesAdministrativos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        public DataTable ReporteVentas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BalancesVentas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        public DataTable ReporteFijos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BalancesFijos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }


        public DataTable ReporteVarios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BalancesVarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        public DataTable ReporteProveedores()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BalancesProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        public DataTable ReporteExtraordinarios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BalancesExtraordinarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

    }
}
