using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_GastosVarios
    {

        private PD_GastosVarios objeto = new PD_GastosVarios();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();

            tabla = objeto.Mostrar();

            return tabla;
        }

        public void Insertar(string descripcion, string fecha, string monto)
        {
            objeto.Insertar(descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Actualizar(string idGastosVarios, string descripcion, DateTime fecha, string monto)
        {
            objeto.Actualizar(Convert.ToInt32(idGastosVarios), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Eliminar(string idGastosVarios)
        {
            objeto.Eliminar(Convert.ToInt32(idGastosVarios));
        }

        public DataTable Buscar(string descripcion)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(descripcion);

            return tabla;
        }

        public DataTable BuscarGastosVariosPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarGastosVariosPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }

        public DataTable ReporteGastosVariosPorDescripcion(string descripcion)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteGastosVariosPorDescripcion(descripcion);

            return tabla;
        }

        public DataTable ReporteGastosVariosPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteGastosVariosPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
