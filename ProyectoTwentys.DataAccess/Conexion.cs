using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoTwentys.DataAccess
{
    public class Conexion

    {

        private SqlConnection conexion = new SqlConnection("Server=DESKTOP-16NDHF8;Database=Twentys;Integrated Security=true");


        public SqlConnection AbrirConexion() {
           
            if (conexion.State == ConnectionState.Closed)
            
                conexion.Open();

                return conexion;    
        }


        public SqlConnection CerrarConexion() {

            if (conexion.State == ConnectionState.Open)

                conexion.Close();

            return conexion;


        }
    }

     
}
