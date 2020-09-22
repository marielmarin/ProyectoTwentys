using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTwentys.DataAccess;


namespace ProyectoTwentys.Business
{
    public class PB_SobrantesYFaltantes
    {
        
         private PD_SobrantesYFaltantes objeto = new PD_SobrantesYFaltantes();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();

            tabla = objeto.Mostrar();

            return tabla;
        }

         public void Insertar(string idEmpleado,  string fecha, string monto, string tipo)
        {
            objeto.Insertar(Convert.ToInt32(idEmpleado), Convert.ToDateTime(fecha), Convert.ToDouble(monto), tipo);
        }

        public void Actualizar(string idSobrantesYFaltantes, string idEmpleado, DateTime fecha, string monto, string tipo)
        {
            objeto.Actualizar(Convert.ToInt32(idSobrantesYFaltantes), Convert.ToInt32(idEmpleado), Convert.ToDateTime(fecha), Convert.ToDouble(monto), tipo);
        }    

        public void Eliminar(string idEmpleado, string idSobrantesYFaltantes)
        {
            objeto.Eliminar(Convert.ToInt32(idEmpleado), Convert.ToInt32(idSobrantesYFaltantes));
        }

        public DataTable Buscar(string idEmpleado)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Buscar(Convert.ToInt32(idEmpleado));

            return tabla;
        }

        public DataTable BuscarSobrantesYFaltantesPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla = objeto.BuscarSobrantesYFaltantesPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }

        public DataTable ReporteSobrantesYFaltantesPorEmpleado(string idEmpleado)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteSobrantesYFaltantesPorEmpleado(Convert.ToInt32(idEmpleado));

            return tabla;
        }

        public DataTable ReporteSobrantesYFaltantesPorFecha(string fechaInicio, string fechaFinal)
        {
            DataTable tabla = new DataTable();

            tabla = objeto.ReporteSobrantesYFaltantesPorFecha(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));

            return tabla;
        }
    }
}
