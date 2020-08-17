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
    public class PB_Proveedores
    {

        private PD_Proveedores objeto = new PD_Proveedores();

        public DataTable Mostrar() {

            DataTable tabla = new DataTable();
            tabla = objeto.Mostrar();

            return tabla;
        }


        public DataTable MostrarIngreso()
        {

            DataTable tabla = new DataTable();
            tabla = objeto.MostrarIngreso();

            return tabla;
        }


        public void Insertar(string cedulaJuridica, string nombre, string telefono, string direccion) {
            objeto.Insertar(Convert.ToInt32(cedulaJuridica), nombre, Convert.ToInt32(telefono), direccion);
        }

        public void InsertarIngreso(string cedulaJuridica, string descripcion, string fecha, string monto)
        {
            objeto.InsertarIngreso(Convert.ToInt32(cedulaJuridica), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Actualizar(string cedulaJuridica, string nombre, string telefono, string direccion)
        {
            objeto.Actualizar(Convert.ToInt32(cedulaJuridica), nombre, Convert.ToInt32(telefono), direccion);
        }

        public void ActualizarIngreso(string idTransaccion, string cedulaJuridica, string descripcion, DateTime fecha, double monto)
        {
            objeto.ActualizarIngreso(Convert.ToInt32(idTransaccion), Convert.ToInt32(cedulaJuridica), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Eliminar(string cedulaJuridica)
        {
            objeto.Eliminar(Convert.ToInt32(cedulaJuridica));
        }

        public void EliminarIngreso(string cedulaJuridica, string idTransaccion)
        {
            objeto.EliminarIngreso(Convert.ToInt32(cedulaJuridica), Convert.ToInt32(idTransaccion));
        }

        public DataTable Buscar(string cedulaJuridica)
        {  
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(Convert.ToInt32(cedulaJuridica));

            return tabla;
        }

        public DataTable BuscarIngreso(string cedulaJuridica)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarIngreso(Convert.ToInt32(cedulaJuridica));

            return tabla;
        }

        public DataTable BuscarPorFechas(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarPorFechas(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }

        public DataTable ReporteProveedorPorCedula(string cedulaJuridica)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteProveedorPorCedula(Convert.ToInt32(cedulaJuridica));

            return tabla;
        }

        public DataTable ReporteProveedorPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteProveedorPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
