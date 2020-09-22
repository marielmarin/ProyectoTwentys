using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoTwentys.DataAccess
{
    public class PD_Empleados
    {

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEmpleados"; //PROCEDIMIENTO ALMACENADO
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string nombre, string correo, int telefono, double pagoPorHora, double salarioMinimo, string puesto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@pagoPorHora", pagoPorHora);
            comando.Parameters.AddWithValue("@salarioMinimo", salarioMinimo);
            comando.Parameters.AddWithValue("@puesto", puesto);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Actualizar(int idEmpleado, string nombre, string correo, int telefono, double pagoPorHora, double salarioMinimo, string puesto)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@pagoPorHora", pagoPorHora);
            comando.Parameters.AddWithValue("@salarioMinimo", salarioMinimo);
            comando.Parameters.AddWithValue("@puesto", puesto);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void Eliminar(int idEmpleado)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comando.Parameters.Clear();
            }
            catch (Exception eX)
            {

                MessageBox.Show("No se pudo eliminar los datos porque hay datos relacionados con el ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        public DataTable Buscar(string nombre)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
