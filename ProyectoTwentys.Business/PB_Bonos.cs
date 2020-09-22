using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_Bonos
    {


        private PD_Bonos objeto = new PD_Bonos();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();

            tabla = objeto.Mostrar();

            return tabla;
        }

        public void Insertar(string idDeuda,  string fecha, string monto)
        {
            objeto.Insertar(Convert.ToInt32(idDeuda), Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Actualizar(string idBono, string idDeuda, DateTime fecha, string monto)
        {
            objeto.Actualizar(Convert.ToInt32(idBono), Convert.ToInt32(idDeuda), Convert.ToDateTime(fecha), Convert.ToDouble(monto));
        }

        public void Eliminar(string idDeuda, string idBono)
        {
            objeto.Eliminar(Convert.ToInt32(idDeuda), Convert.ToInt32(idBono));
        }

        public DataTable Buscar(string idDeuda)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(Convert.ToInt32(idDeuda));

            return tabla;
        }

        public DataTable BuscarBonoPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarBonoPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }

        public DataTable ReporteBonoPorDeuda(string idDeuda)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteBonoPorDeuda(Convert.ToInt32(idDeuda));

            return tabla;
        }

        public DataTable ReporteBonoPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteBonoPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
