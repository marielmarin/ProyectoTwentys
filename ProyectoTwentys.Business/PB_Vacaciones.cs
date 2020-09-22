using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_Vacaciones
    {

        private PD_Vacaciones objeto = new PD_Vacaciones();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();

            tabla = objeto.Mostrar();

            return tabla;
        }

        public void Insertar(string idEmpleado, string fecha, string cantidadHoras)
        {
            objeto.Insertar(Convert.ToInt32(idEmpleado), Convert.ToDateTime(fecha), Convert.ToInt32(cantidadHoras));
        }

        public void Actualizar(string idVacaciones, string idEmpleado,  DateTime fecha, string cantidadHoras)
        {
            objeto.Actualizar(Convert.ToInt32(idVacaciones), Convert.ToInt32(idEmpleado), Convert.ToDateTime(fecha), Convert.ToInt32(cantidadHoras));
        }

        public void Eliminar(string idEmpleado, string idVacaciones)
        {
            objeto.Eliminar(Convert.ToInt32(idEmpleado), Convert.ToInt32(idVacaciones));
        }

        public DataTable Buscar(string idEmpleado)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(Convert.ToInt32(idEmpleado));

            return tabla;
        }

        public DataTable BuscarVacacionesPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarVacacionesPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }

        public DataTable ReporteVacacionesPorEmpleado(string idEmpleado)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteVacacionesPorEmpleado(Convert.ToInt32(idEmpleado));

            return tabla;
        }

        public DataTable ReporteVacacionesPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteVacacionesPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
