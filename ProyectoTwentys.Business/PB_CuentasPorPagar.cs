using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_CuentasPorPagar
    {

        private PD_CuentasPorPagar objeto = new PD_CuentasPorPagar();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();

            tabla = objeto.Mostrar();

            return tabla;
        }

         public void Insertar(string cedulaJuridica, string descripcion, string fecha, string monto, string estado)
        {
            objeto.Insertar(Convert.ToInt32(cedulaJuridica), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto), estado);
        }

        public void Actualizar(string idTransaccion, string cedulaJuridica, string descripcion, DateTime fecha, string monto, string estado)
        {
            objeto.Actualizar(Convert.ToInt32(idTransaccion), Convert.ToInt32(cedulaJuridica), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto), estado);
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

        public DataTable ReporteCuentasPorPagarPorCedula(string cedulaJuridica)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteCuentasPorPagarPorCedula(Convert.ToInt32(cedulaJuridica));

            return tabla;
        }

        public DataTable ReporteCuentasPorPagarPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteCuentasPorPagarPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
