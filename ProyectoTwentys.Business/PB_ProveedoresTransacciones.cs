using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_ProveedoresTransacciones
    {

        private PD_ProveedoresTransacciones objeto = new PD_ProveedoresTransacciones();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();

            tabla = objeto.Mostrar();

            return tabla;
        }

         public void Insertar(string cedulaJuridica, string descripcion, string fecha, string monto)
        {
            objeto.Insertar(Convert.ToInt32(cedulaJuridica), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Actualizar(string idTransaccion, string cedulaJuridica, string descripcion, DateTime fecha, double monto)
        {
            objeto.Actualizar(Convert.ToInt32(idTransaccion), Convert.ToInt32(cedulaJuridica), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }    

        public void Eliminar(string cedulaJuridica, string idTransaccion)
        {
            objeto.Eliminar(Convert.ToInt32(cedulaJuridica), Convert.ToInt32(idTransaccion));
        }

        public DataTable Buscar(string cedulaJuridica)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(Convert.ToInt32(cedulaJuridica));

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
