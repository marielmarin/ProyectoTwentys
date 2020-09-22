using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_Vales
    {

        private PD_Vales objeto = new PD_Vales();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();

            tabla = objeto.Mostrar();

            return tabla;
        }

        public void Insertar(string idCuentasPorPagar, string descripcion, string fecha, string monto)
        {
            objeto.Insertar(Convert.ToInt32(idCuentasPorPagar), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Actualizar(string idVales, string idCuentasPorPagar, string descripcion, DateTime fecha, string monto)
        {
            objeto.Actualizar(Convert.ToInt32(idVales), Convert.ToInt32(idCuentasPorPagar), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Eliminar(string idCuentasPorPagar, string idVales)
        {
            objeto.Eliminar(Convert.ToInt32(idCuentasPorPagar), Convert.ToInt32(idVales));
        }

        public DataTable Buscar(string idCuentasPorPagar)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(Convert.ToInt32(idCuentasPorPagar));

            return tabla;
        }

        public DataTable BuscarValesPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarValesPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }

        public DataTable ReporteValesPorCuentasPorCobrar(string idCuentasPorPagar)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteValesPorCuentasPorCobrar(Convert.ToInt32(idCuentasPorPagar));

            return tabla;
        }

        public DataTable ReporteValesPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteValesPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
