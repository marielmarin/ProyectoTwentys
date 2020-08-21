using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProyectoTwentys.DataAccess;

namespace ProyectoTwentys.Business
{
    public class PB_Proveedores
    {

        private PD_Proveedores objeto = new PD_Proveedores();

        public DataTable Mostrar() {

            DataTable tabla = new DataTable();
            tabla = objeto.Mostrar();

            return tabla;
        }

        public void Insertar(string cedulaJuridica, string nombre, string telefono, string direccion) {
            objeto.Insertar(Convert.ToInt32(cedulaJuridica), nombre, Convert.ToInt32(telefono), direccion);
        }

        public void Actualizar(string cedulaJuridica, string nombre, string telefono, string direccion)
        {
            objeto.Actualizar(Convert.ToInt32(cedulaJuridica), nombre, Convert.ToInt32(telefono), direccion);
        }

        public void Eliminar(string cedulaJuridica)
        {
            objeto.Eliminar(Convert.ToInt32(cedulaJuridica));
        }

        public DataTable Buscar(string nombre)
        {  
            DataTable tabla = new DataTable();

            tabla = objeto.Buscar(nombre);

            return tabla;
        }

    }
}
