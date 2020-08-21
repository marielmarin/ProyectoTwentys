using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTwentys.Business
{
    public class Validaciones
    {

        public static void soloLetras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsSeparator(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public static void soloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !(char.IsSeparator(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten números", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    
        }
}
