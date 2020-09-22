using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTwentys.Business;

namespace ProyectoTwentys
{
    public partial class Balances : Form
    {
        public Balances()
        {
            InitializeComponent();
        }

        private void Balances_Load(object sender, EventArgs e)
        {
            tablaReportes.Visible = false;
            MostrarGastosAdministrativos();
            MostrarGastosFijos();
            MostrarGastosVarios();
            MostrarGastosExtraordinarios();
            MostrarProveedores();
           
        }


        private double totalVentas()
        {
            PB_Balances objetoMostrar = new PB_Balances();

            double totalVentas;

            tablaReportes.DataSource = objetoMostrar.ReporteVentas();

            totalVentas = Convert.ToDouble(tablaReportes.CurrentRow.Cells["SumaMontoVentas"].Value.ToString());

            return totalVentas;
        }

        private void MostrarGastosAdministrativos()
        {
            PB_Balances objetoMostrar = new PB_Balances();

            double totalGastosAdministrativos;

            double total;

            tablaReportes.DataSource = objetoMostrar.ReporteGastosAdministrativos();

            txtGastosAdministrativos.Text = tablaReportes.CurrentRow.Cells["SumaMontoGastosAdiministrativos"].Value.ToString();

            totalGastosAdministrativos = Convert.ToDouble(tablaReportes.CurrentRow.Cells["SumaMontoGastosAdiministrativos"].Value.ToString());

            total = totalGastosAdministrativos / totalVentas() * 100;

            lblPorcentajeAdministrativos.Text = Convert.ToString(total);

            if (total == 12)
            {

                lblPorcentajeAdministrativos.ForeColor = Color.Green;
            }
            else
            {

                lblPorcentajeAdministrativos.ForeColor = Color.Red;

            }

        }

        private void MostrarGastosFijos()
        {
            PB_Balances objetoMostrar = new PB_Balances();

            double totalGastosFijos;

            double total;

            tablaReportes.DataSource = objetoMostrar.ReporteFijos();

            txtGastosFijos.Text = tablaReportes.CurrentRow.Cells["SumaMontoFijos"].Value.ToString();

            totalGastosFijos = Convert.ToDouble(tablaReportes.CurrentRow.Cells["SumaMontoFijos"].Value.ToString());

            total = totalGastosFijos / totalVentas() * 100;

            lblPorcentajeFijos.Text = Convert.ToString(total);

            if (total == 10)
            {

                lblPorcentajeFijos.ForeColor = Color.Green;
            }
            else
            {

                lblPorcentajeFijos.ForeColor = Color.Red;

            }



        }

        private void MostrarGastosVarios()
        {
            PB_Balances objetoMostrar = new PB_Balances();

            double totalGastosVarios;

            double total;

            tablaReportes.DataSource = objetoMostrar.ReporteVarios();

            txtGastosVarios.Text = tablaReportes.CurrentRow.Cells["SumaMontoVarios"].Value.ToString();

            totalGastosVarios = Convert.ToDouble(tablaReportes.CurrentRow.Cells["SumaMontoVarios"].Value.ToString());

            total = totalGastosVarios / totalVentas() * 100;

            lblPorcentajeVarios.Text = Convert.ToString(total);

            if (total == 5)
            {

                lblPorcentajeVarios.ForeColor = Color.Green;
            }
            else
            {

                lblPorcentajeVarios.ForeColor = Color.Red;

            }

        }

        private void MostrarProveedores()
        {
            PB_Balances objetoMostrar = new PB_Balances();

            double totalProveedores;

            double total;

            tablaReportes.DataSource = objetoMostrar.ReporteProveedores();

            txtProveedores.Text = tablaReportes.CurrentRow.Cells["SumaMontoProveedores"].Value.ToString();

            totalProveedores = Convert.ToDouble(tablaReportes.CurrentRow.Cells["SumaMontoProveedores"].Value.ToString());

            total = totalProveedores / totalVentas() * 100;

            lblPorcentajeProveedores.Text = Convert.ToString(total);

            if (total == 55)
            {

                lblPorcentajeProveedores.ForeColor = Color.Green;
            }
            else
            {

                lblPorcentajeProveedores.ForeColor = Color.Red;

            }

        }


        private void MostrarGastosExtraordinarios()
        {
            PB_Balances objetoMostrar = new PB_Balances();

            double totalExtraordinarios;

            double total;

            tablaReportes.DataSource = objetoMostrar.ReporteExtraordinarios();

            txtGastosExtraordinarios.Text = tablaReportes.CurrentRow.Cells["SumaMontoExtraordinarios"].Value.ToString();

            totalExtraordinarios = Convert.ToDouble(tablaReportes.CurrentRow.Cells["SumaMontoExtraordinarios"].Value.ToString());

            total = totalExtraordinarios / totalVentas() * 100;

            lblPorcentajeExtraordinarios.Text = Convert.ToString(total);

            if (total == 0)
            {

                lblPorcentajeExtraordinarios.ForeColor = Color.Green;
            }
            else
            {

                lblPorcentajeExtraordinarios.ForeColor = Color.Red;

            }

        }



    }
}
