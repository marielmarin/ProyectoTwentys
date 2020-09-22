using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_Viaticos
    {

         private PD_Viaticos objeto = new PD_Viaticos();

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

        public void Actualizar(string idViatico, string idEmpleado, string descripcion, DateTime fecha, string monto)
        {
            objeto.Actualizar(Convert.ToInt32(idViatico), Convert.ToInt32(idEmpleado), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }    

        public void Eliminar(string idEmpleado, string idViatico)
        {
            objeto.Eliminar(Convert.ToInt32(idEmpleado), Convert.ToInt32(idViatico));
        }

        public DataTable Buscar(string idEmpleado)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(Convert.ToInt32(idEmpleado));

            return tabla;
        }

        public DataTable BuscarViaticosPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarViaticosPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }

        public DataTable ReporteViaticosPorEmpleado(string idEmpleado)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteViaticosPorEmpleado(Convert.ToInt32(idEmpleado));

            return tabla;
        }

        public DataTable ReporteViaticosPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteViaticosPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
