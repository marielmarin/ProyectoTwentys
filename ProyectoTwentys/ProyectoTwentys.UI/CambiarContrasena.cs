using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoTwentys
{
    public partial class CambiarContrasena : Form
    {
        public CambiarContrasena()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CambiarContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ImagenTwentys_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtContrasenaActual_Enter(object sender, EventArgs e)
        {
            if (txtContrasenaActual.Text == "CONTRASEÑA ACTUAL ")
            {
               // txtContrasenaActual.Text = "";
               // txtContrasenaActual.ForeColor = Color.Black;
              //  txtContrasenaActual.UseSystemPasswordChar = true;
            }

        }

        private void txtContrasenaActual_Leave(object sender, EventArgs e)
        {
            if (txtContrasenaActual.Text == "")
            {
                txtContrasenaActual.Text = "CONTRASEÑA ACTUAL ";
                txtContrasenaActual.ForeColor = Color.Black;
                txtContrasenaActual.UseSystemPasswordChar = false;
            }

        }

        private void txtContrasenaNueva_Enter(object sender, EventArgs e)
        {
            if (txtContrasenaNueva.Text == "CONTRASEÑA NUEVA")
            {
                txtContrasenaNueva.Text = "";
                txtContrasenaNueva.ForeColor = Color.Black;
                txtContrasenaNueva.UseSystemPasswordChar = true;
            }

        }

        private void txtContrasenaNueva_Leave(object sender, EventArgs e)
        {
            if (txtContrasenaNueva.Text == "")
            {
                txtContrasenaNueva.Text = "CONTRASEÑA NUEVA";
                txtContrasenaNueva.ForeColor = Color.Black;
                txtContrasenaNueva.UseSystemPasswordChar = false;
            }

        }

      
        private void txtConfirmarContrasena_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarContrasena.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtConfirmarContrasena.Text = "";
                txtConfirmarContrasena.ForeColor = Color.Black;
                txtConfirmarContrasena.UseSystemPasswordChar = true;
            }

        }

        private void txtConfirmarContrasena_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarContrasena.Text == "")
            {
                txtConfirmarContrasena.Text = "CONFIRMAR CONTRASEÑA";
                txtConfirmarContrasena.ForeColor = Color.Black;
                txtConfirmarContrasena.UseSystemPasswordChar = false;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            InicioDeSesion inicioDeSesion = new InicioDeSesion();
            inicioDeSesion.ShowDialog();

        }


    }
}
