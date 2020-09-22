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
    public partial class CuentasPorCobrar : Form
    {
        PB_CuentasPorCobrar objeto = new PB_CuentasPorCobrar();
        private bool Editar = false;
        string idEmpleado = null;
        string idCuentasPorCobrar = null;


        public CuentasPorCobrar()
        {
            InitializeComponent();
        }

        private void CuentasPorCobrar_Load(object sender, EventArgs e)
        {
            Mostrar();
            tablaReportes.Visible = false;
            txtTotalReporte.Enabled = false;
        }


        //MOSTRAR
        private void Mostrar()
        {
            PB_CuentasPorCobrar objetoMostrar = new PB_CuentasPorCobrar();
            tablaIngresoInformacion.DataSource = objetoMostrar.Mostrar();
        }


        //INSERTAR
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    if (validarCamposVacios() == true)
                    {
                        MessageBox.Show("No se ingresaron bien los datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        objeto.Insertar(txtIDEmpleado.Text, txtDescripcion.Text, txtFecha.Text, txtMonto.Text);
                        MessageBox.Show("Se insertó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (Editar == true)
            {

                try
                {
                    if (validarCamposVacios() == true)
                    {
                        MessageBox.Show("No se ingresaron bien los datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        objeto.Actualizar(idCuentasPorCobrar, txtIDEmpleado.Text, txtDescripcion.Text, txtFecha.Value, txtMonto.Text);
                        MessageBox.Show("Se editó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                        Editar = false;
                        txtIDEmpleado.Enabled = true;
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo editar los datos por " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //ACTUALIZAR
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (tablaIngresoInformacion.SelectedRows.Count > 0)
            {
                Editar = true;

                idCuentasPorCobrar = tablaIngresoInformacion.CurrentRow.Cells["idCuentasPorCobrar"].Value.ToString();
                txtIDEmpleado.Text = tablaIngresoInformacion.CurrentRow.Cells["idEmpleado"].Value.ToString();
                txtDescripcion.Text = tablaIngresoInformacion.CurrentRow.Cells["descripcion"].Value.ToString();
                txtFecha.Text = tablaIngresoInformacion.CurrentRow.Cells["fecha"].Value.ToString();
                txtMonto.Text = tablaIngresoInformacion.CurrentRow.Cells["monto"].Value.ToString();
                txtIDEmpleado.Enabled = false;
            }
            else
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        //ELIMINAR 
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (tablaIngresoInformacion.SelectedRows.Count > 0)
            {
                idEmpleado = tablaIngresoInformacion.CurrentRow.Cells["idEmpleado"].Value.ToString();
                idCuentasPorCobrar = tablaIngresoInformacion.CurrentRow.Cells["idCuentasPorCobrar"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    objeto.Eliminar(idEmpleado, idCuentasPorCobrar);
                    MessageBox.Show("Se eliminó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                }

            }
            else
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PB_CuentasPorCobrar objetoMostrar = new PB_CuentasPorCobrar();


            if (txtIDEmpleado.Text != "")
            {
                idEmpleado = txtIDEmpleado.Text;
                tablaIngresoInformacion.DataSource = objetoMostrar.Buscar(idEmpleado);

                if (tablaIngresoInformacion.Rows.Count == 1)
                {

                    MessageBox.Show("No existen datos relacionados con el ID", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDEmpleado.Text = "";
                }
                else
                {
                    MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Ingrese el ID", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //REPORTES 
        private void btnAceptarReportes_Click(object sender, EventArgs e)
        {

            PB_CuentasPorCobrar objetoMostrar = new PB_CuentasPorCobrar();

            try
            {

                if (txtIDEmpleadoReporte.Text != "" && txtFechaInicio.CustomFormat != " " && txtFechaFinal.CustomFormat != " ")
                {

                    MessageBox.Show("No se pudo encontrar los datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtIDEmpleadoReporte.Text == "" && txtFechaInicio.CustomFormat == " " && txtFechaFinal.CustomFormat == " ")
                {

                    MessageBox.Show("No se pudo encontrar los datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtFechaInicio.CustomFormat == " " && txtFechaFinal.CustomFormat != " " || txtFechaInicio.CustomFormat != " " && txtFechaFinal.CustomFormat == " ")
                {

                    MessageBox.Show("No se pudo encontrar los datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtIDEmpleadoReporte.Text != "")
                {
                    idEmpleado = txtIDEmpleadoReporte.Text;
                    tablaIngresoInformacion.DataSource = objetoMostrar.Buscar(idEmpleado);

                    tablaReportes.DataSource = objetoMostrar.ReporteCuentasPorCobrarPorEmpleado(idEmpleado);

                    txtTotalReporte.Text = tablaReportes.CurrentRow.Cells["SumaMonto"].Value.ToString();

                    if (tablaIngresoInformacion.Rows.Count == 1)
                    {

                        MessageBox.Show("No existen datos relacionados con el ID", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIDEmpleadoReporte.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIDEmpleadoReporte.Text = "";
                    }
                }
                else if (txtFechaInicio.CustomFormat != " " && txtFechaFinal.CustomFormat != " ")
                {


                    tablaIngresoInformacion.DataSource = objetoMostrar.BuscarCuentasPorCobrarPorFecha(txtFechaInicio.Text, txtFechaFinal.Text);

                    tablaReportes.DataSource = objetoMostrar.ReporteCuentasPorCobrarPorFecha(txtFechaInicio.Text, txtFechaFinal.Text);

                    txtTotalReporte.Text = tablaReportes.CurrentRow.Cells["SumaMonto"].Value.ToString();

                    if (tablaIngresoInformacion.Rows.Count == 1)
                    {

                        MessageBox.Show("No existen datos relacionados con las fechas ingresadas", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtFechaInicio.CustomFormat = " ";
                        txtFechaFinal.CustomFormat = " ";
                    }
                    else
                    {
                        MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFechaInicio.CustomFormat = " ";
                        txtFechaFinal.CustomFormat = " ";

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo encontrar los datos." + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //LIMPIAR 
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiarTabla_Click(object sender, EventArgs e)
        {
            Mostrar();
        }


        private void btnLimpiarReportesPorCedula_Click(object sender, EventArgs e)
        {
            txtIDEmpleadoReporte.Clear();
            txtFechaInicio.CustomFormat = " ";
            txtFechaFinal.CustomFormat = " ";
            txtTotalReporte.Clear();
        }

        //METODOS
        private void Limpiar()
        {

            if (txtIDEmpleado.Enabled == false)
            {

                txtDescripcion.Text = "";
                txtFecha.CustomFormat = " ";
                txtMonto.Clear();

            }
            else
            {
                txtIDEmpleado.Clear();
                txtDescripcion.Text = "";
                txtFecha.CustomFormat = " ";
                txtMonto.Clear();
            }

        }

        //VALIDACIONES 
        private void txtIDEmpleadoIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtIDEmpleadoReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private bool validarCamposVacios()
        {

            bool datosVacios = false;

            if (txtIDEmpleado.Text == "" | txtDescripcion.Text == "" | txtFecha.Text == "" | txtMonto.Text == "")
            {
                datosVacios = true;
            }

            return datosVacios;

        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {
            txtFecha.CustomFormat = "dd/MM/yyyy";

            if (txtFecha.Value > DateTime.Today)
            {

                MessageBox.Show("Fecha no válida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtFecha.CustomFormat = " ";

            }
        }

        private void txtFecha_KeyDown(object sender, KeyEventArgs e)

        {
            txtFecha.CustomFormat = " ";
        }

        private void txtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            txtFechaInicio.CustomFormat = "dd/MM/yyyy";


        }

        private void txtFechaInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                txtFechaInicio.CustomFormat = " ";
            }
        }

        private void txtFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            txtFechaFinal.CustomFormat = "dd/MM/yyyy";

            if (txtFechaFinal.Value < txtFechaInicio.Value)
            {

                MessageBox.Show("Fechas no válidas.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtFechaFinal.CustomFormat = " ";
                txtFechaInicio.CustomFormat = " ";

            }
        }

        private void txtFechaFinal_KeyDown(object sender, KeyEventArgs e)
        {
            txtFechaFinal.CustomFormat = " ";
        }


        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadosConsulta empleadosConsulta = new EmpleadosConsulta();

            empleadosConsulta.ShowDialog();

            txtIDEmpleado.Text = empleadosConsulta.idEmpleadoBuscar;
        }

        private void btnBuscarEmpleado2_Click(object sender, EventArgs e)
        {
            EmpleadosConsulta empleadosConsulta = new EmpleadosConsulta();

            empleadosConsulta.ShowDialog();

            txtIDEmpleadoReporte.Text = empleadosConsulta.idEmpleadoBuscar;

        }
    }
}
