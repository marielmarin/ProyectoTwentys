using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;


namespace ProyectoTwentys.Business
{
    public class PB_Balances
    {

        private PD_Balances objeto = new PD_Balances();


        public DataTable ReporteGastosAdministrativos()
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteGastosAdministrativos();

            return tabla;
        }

        public DataTable ReporteVentas()
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteVentas();

            return tabla;
        }

        public DataTable ReporteFijos()
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteFijos();

            return tabla;
        }

        public DataTable ReporteVarios()
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteVarios();

            return tabla;
        }

        public DataTable ReporteProveedores()
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteProveedores();

            return tabla;
        }

        public DataTable ReporteExtraordinarios()
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteExtraordinarios();

            return tabla;
        }
    }
}
