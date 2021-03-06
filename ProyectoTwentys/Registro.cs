﻿using System;
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
    public partial class Registro : Form
    {
        public Registro()
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


        private void ImagenTwentys_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Registro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO") {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {

            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = true;
            }

        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = false;
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

            //if (txtContrasena.Text == txtConfirmarContrasena.Text) {


            //    if (ProyectoTwentys.DataAccess.PD_Usuarios.CrearCuentas(txtUsuario.Text, txtContrasena.Text) > 0)
            //    {

            //        MessageBox.Show("Cuenta creada con éxito");

                    InicioDeSesion inicioDeSesion = new InicioDeSesion();
                    inicioDeSesion.ShowDialog();


                //}
                //else {

                //    MessageBox.Show("No se pudo crear la cuenta");
                //}


           // }

           

        }

    }
}
