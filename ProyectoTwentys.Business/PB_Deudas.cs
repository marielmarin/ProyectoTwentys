using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;


namespace ProyectoTwentys.Business
{
    public class PB_Deudas
    {

        private PD_Deudas objeto = new PD_Deudas();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();

            tabla = objeto.Mostrar();

            return tabla;
        }

        public void Insertar( string idEmpleado, string descripcion, string monto, string estado )
        {
            objeto.Insertar( Convert.ToInt32(idEmpleado), descripcion,  Convert.ToDouble(monto), estado);
        }

        public void Actualizar(string idDeuda, string idEmpleado, string descripcion, string monto, string estado)
        {
            objeto.Actualizar(Convert.ToInt32(idDeuda), Convert.ToInt32(idEmpleado), descripcion, Convert.ToDouble(monto), estado);
        }

        public void Eliminar(string idEmpleado, string idDeudas)
        {
            objeto.Eliminar(Convert.ToInt32(idEmpleado), Convert.ToInt32(idDeudas));
        }

        public DataTable Buscar(string idEmpleado)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(Convert.ToInt32(idEmpleado));

            return tabla;
        }

      
        public DataTable ReporteDeudasPorEmpleado(string idEmpleado)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteDeudasPorEmpleado(Convert.ToInt32(idEmpleado));

            return tabla;
        }
    }
}
