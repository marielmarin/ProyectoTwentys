using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;


namespace ProyectoTwentys.Business
{
    public class PB_Publicidad
    {

        private PD_Publicidad objeto = new PD_Publicidad();

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

        public void Actualizar(string idPublicidad, string descripcion, DateTime fecha, string monto)
        {
            objeto.Actualizar(Convert.ToInt32(idPublicidad), descripcion, Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Eliminar( string idPublicidad)
        {
            objeto.Eliminar(Convert.ToInt32(idPublicidad));
        }

        public DataTable Buscar(string descripcion)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(descripcion);

            return tabla;
        }

        public DataTable BuscarPublicidadPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarPublicidadPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }

        public DataTable ReportePublicidadPorDescripcion(string descripcion)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReportePublicidadPorDescripcion(descripcion);

            return tabla;
        }

        public DataTable ReportePublicidadPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReportePublicidadPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
