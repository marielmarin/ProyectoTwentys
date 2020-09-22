using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_GastosExtraordinarios
    {

        private PD_GastosExtraordinarios objeto = new PD_GastosExtraordinarios();

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

        public void Actualizar(string idGastosExtraordinarios, string descripcion, string monto)
        {
            objeto.Actualizar(Convert.ToInt32(idGastosExtraordinarios), descripcion, Convert.ToDouble(monto));
        }

        public void Eliminar(string idGastosExtraordinarios)
        {
            objeto.Eliminar(Convert.ToInt32(idGastosExtraordinarios));
        }

        public DataTable Buscar(string descripcion)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(descripcion);

            return tabla;
        }

        public DataTable ReportesGastosExtraordinarios(string descripcion)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReportesGastosExtraordinarios(descripcion);

            return tabla;
        }


    }
}
