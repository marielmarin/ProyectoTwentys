using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_GastosFijos
    {


        private PD_GastosFijos objeto = new PD_GastosFijos();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();

            tabla = objeto.Mostrar();

            return tabla;
        }

        public void Insertar(string descripcion, string monto)
        {
            objeto.Insertar(descripcion, Convert.ToDouble(monto));
        }

        public void Actualizar(string idGastosFijos, string descripcion, string monto)
        {
            objeto.Actualizar(Convert.ToInt32(idGastosFijos), descripcion, Convert.ToDouble(monto));
        }

        public void Eliminar( string idGastosFijos)
        {
            objeto.Eliminar(Convert.ToInt32(idGastosFijos));
        }

        public DataTable Buscar(string descripcion)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(descripcion);

            return tabla;
        }

        public DataTable ReportesGastosFijos(string descripcion)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReportesGastosFijos(descripcion);

            return tabla;
        }

      
    }
}
