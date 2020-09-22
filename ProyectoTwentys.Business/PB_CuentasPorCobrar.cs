using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_CuentasPorCobrar
    {

        private PD_CuentasPorCobrar objeto = new PD_CuentasPorCobrar();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();

            tabla = objeto.Mostrar();

            return tabla;
        }

        public void Insertar(string idEmpleado, string descripcion, string fecha, string monto)
        {
            objeto.Insertar(Convert.ToInt32(idEmpleado), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Actualizar(string idCuentasPorCobrar, string idEmpleado, string descripcion, DateTime fecha, string monto)
        {
            objeto.Actualizar(Convert.ToInt32(idCuentasPorCobrar), Convert.ToInt32(idEmpleado), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Eliminar(string idEmpleado, string idCuentasPorCobrar)
        {
            objeto.Eliminar(Convert.ToInt32(idEmpleado), Convert.ToInt32(idCuentasPorCobrar));
        }

        public DataTable Buscar(string idEmpleado)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(Convert.ToInt32(idEmpleado));

            return tabla;
        }

        public DataTable BuscarCuentasPorCobrarPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarCuentasPorCobrarPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }

        public DataTable ReporteCuentasPorCobrarPorEmpleado(string idEmpleado)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteCuentasPorCobrarPorEmpleado(Convert.ToInt32(idEmpleado));

            return tabla;
        }

        public DataTable ReporteCuentasPorCobrarPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteCuentasPorCobrarPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
