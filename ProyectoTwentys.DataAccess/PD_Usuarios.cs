using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProyectoTwentys.DataAccess
{
    public class PD_Usuarios
    {
        //private Conexion conexion = new Conexion();

        //SqlDataReader leer;
        //DataTable tabla = new DataTable();
        //SqlCommand comando = new SqlCommand();

        //public DataTable Mostrar() {

        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = "Select *from Proveedores";
        //    leer = comando.ExecuteReader();
        //    tabla.Load(leer);
        //    conexion.CerrarConexion();
        //    return tabla;

        //}



        //public static int CrearCuentas(string usuario, string contrasena) {

        //    int resultado = 0;

        //    SqlConnection conexion = Conexion.AbrirConexion();

        //    SqlCommand comando = new SqlCommand(string.Format("Insert Into Usuarios (nombre, contrasena) values ('{0}', PwdEncrypt('{1}'))", usuario, contrasena), conexion);

        //    resultado = comando.ExecuteNonQuery();

        //    conexion.Close();

        //    return resultado;
        // } 

    }
}
