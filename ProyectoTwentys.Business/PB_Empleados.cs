using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_Empleados
    {

        private PD_Empleados objeto = new PD_Empleados();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();
            tabla = objeto.Mostrar();

            return tabla;
        }

        public void Insertar(string nombre, string correo, string telefono, string pagoPorHora, string salarioMinimo, string puesto)
        {
            objeto.Insertar( nombre, correo, Convert.ToInt32(telefono), Convert.ToDouble(pagoPorHora), Convert.ToDouble(salarioMinimo), puesto);
        }

        public void Actualizar(string idEmpleado, string nombre, string correo, string telefono, string pagoPorHora, string salarioMinimo, string puesto)
        {
            objeto.Actualizar(Convert.ToInt32(idEmpleado), nombre, correo, Convert.ToInt32(telefono), Convert.ToDouble(pagoPorHora), Convert.ToDouble(salarioMinimo), puesto);
        }

        public void Eliminar(string idEmpleado)
        {
            objeto.Eliminar(Convert.ToInt32(idEmpleado));
        }

        public DataTable Buscar(string nombre)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.Buscar(nombre);

            return tabla;
        }

    }
}
