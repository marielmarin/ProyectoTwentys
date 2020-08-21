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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            this.WindowState = FormWindowState.Maximized;        
            InitializeComponent();
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true; 
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormHija(object formHija) {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            fh.Show();

        }

        private void btnBalances_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Balances());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Proveedores());
        }

        private void btnProveedoresTransacciones_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Proveedores_Transacciones());
        }

        private void btnCuentasPorPagar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new CuentasPorPagar());
        }

        private void btnGastosFijos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new GastosFijos());
        }

        private void btnPublicidad_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Publicidad());
        }

        private void btnGastosAdministrativos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new GastosAdministrativos());
        }

        private void btnGastosExtraordinarios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new GastosExtraordinarios());
        }

        private void btnGastosVarios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new GastosVarios());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Ventas());
        }

        private void btnOtrosIngresos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new IngresosVarios());
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Efectivo());
        }

        private void btnDolares_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Dolares());
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {

            AbrirFormHija(new Empleados());
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Planilla());
        }

        private void btnCCSS_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new CCSS());
        }

        private void btnViaticos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Viaticos());
        }

        private void btnDeudas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Deudas());
        }

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Vacaciones());
        }

        private void btnSobrantesFaltantes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new SobrantesYFaltantes());
        }

        private void btnCuentasPorCobrar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new CuentasPorCobrar());
        }

        private void btnVales_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Vales());
        }

        
    }
}
