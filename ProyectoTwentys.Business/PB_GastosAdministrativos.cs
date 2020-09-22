using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_GastosAdministrativos
    {

        private PD_GastosAdministrativos objeto = new PD_GastosAdministrativos();

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

        public void Actualizar(string idGastosAdministrativos, string descripcion, DateTime fecha, string monto)
        {
            objeto.Actualizar(Convert.ToInt32(idGastosAdministrativos), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Eliminar(string idGastosAdministrativos)
        {
            objeto.Eliminar(Convert.ToInt32(idGastosAdministrativos));
        }

        public DataTable Buscar(string descripcion)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(descripcion);

            return tabla;
        }

        public DataTable BuscarGastosAdministrativosPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarGastosAdministrativosPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }

        public DataTable ReporteGastosAdministrativosPorDescripcion(string descripcion)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteGastosAdministrativosPorDescripcion(descripcion);

            return tabla;
        }

        public DataTable ReporteGastosAdministrativosPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteGastosAdministrativosPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
