using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_Planilla
    {

        private PD_Planilla objeto = new PD_Planilla();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();

            tabla = objeto.Mostrar();

            return tabla;
        }

        public void Insertar(string idEmpleado, DateTime fecha, string cantidadHoras, string bonificacion, string rebajas)
        {
            objeto.Insertar(Convert.ToInt32(idEmpleado),  Convert.ToDateTime(fecha), Convert.ToInt32(cantidadHoras), Convert.ToDouble(bonificacion), Convert.ToDouble(rebajas));
        }

        public void Actualizar(string idPlanilla, string idEmpleado, DateTime fecha, string cantidadHoras, string bonificacion, string rebajas)
        {
            objeto.Actualizar(Convert.ToInt32(idPlanilla), Convert.ToInt32(idEmpleado), Convert.ToDateTime(fecha), Convert.ToInt32(cantidadHoras), Convert.ToDouble(bonificacion), Convert.ToDouble(rebajas));
        }

        public void Eliminar(string idEmpleado, string idPlanilla)
        {
            objeto.Eliminar(Convert.ToInt32(idEmpleado), Convert.ToInt32(idPlanilla));
        }

        public DataTable Buscar(string idEmpleado)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(Convert.ToInt32(idEmpleado));

            return tabla;
        }

        public DataTable BuscarPlanillaPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarPlanillaPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }

        public DataTable ReportePlanillaPorEmpleado(string idEmpleado)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReportePlanillaPorEmpleado(Convert.ToInt32(idEmpleado));

            return tabla;
        }

        public DataTable ReportePlanillaPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReportePlanillaPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
