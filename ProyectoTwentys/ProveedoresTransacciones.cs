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
    public partial class Proveedores_Transacciones : Form
    {

        PB_ProveedoresTransacciones objeto = new PB_ProveedoresTransacciones();
        private bool Editar = false;
        string idProveedor = null;
        string idTransaccion = null;
       
       
        public Proveedores_Transacciones()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            Mostrar();
            tablaReportes.Visible = false;
            txtTotalReporte.Enabled = false;
        }


        //MOSTRAR
        private void Mostrar()
        {
            PB_ProveedoresTransacciones objetoMostrar = new PB_ProveedoresTransacciones();
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
                        objeto.Insertar(txtCedulaJuridica.Text, txtDescripcion.Text, txtFecha.Text, txtMonto.Text);
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
                        objeto.Actualizar(idTransaccion, txtCedulaJuridica.Text, txtDescripcion.Text, txtFecha.Value, txtMonto.TextLength);
                        MessageBox.Show("Se editó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                        Editar = false;
                        txtCedulaJuridica.Enabled = true;
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

                idTransaccion = tablaIngresoInformacion.CurrentRow.Cells["idTransaccion"].Value.ToString();
                txtCedulaJuridica.Text = tablaIngresoInformacion.CurrentRow.Cells["idProveedor"].Value.ToString();
                txtDescripcion.Text = tablaIngresoInformacion.CurrentRow.Cells["descripcion"].Value.ToString();
                txtFecha.Text = tablaIngresoInformacion.CurrentRow.Cells["fecha"].Value.ToString();
                txtMonto.Text = tablaIngresoInformacion.CurrentRow.Cells["monto"].Value.ToString();
                txtCedulaJuridica.Enabled = false;
            }
            else
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        //ELIMINAR 
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (tablaIngresoInformacion.SelectedRows.Count > 0)
            {
                idProveedor = tablaIngresoInformacion.CurrentRow.Cells["idProveedor"].Value.ToString();
                idTransaccion = tablaIngresoInformacion.CurrentRow.Cells["idTransaccion"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    objeto.Eliminar(idProveedor, idTransaccion);
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
            PB_ProveedoresTransacciones objetoMostrar = new PB_ProveedoresTransacciones();


            if (txtCedulaJuridica.Text != "")
            {
                idProveedor = txtCedulaJuridica.Text;
                tablaIngresoInformacion.DataSource = objetoMostrar.Buscar(idProveedor);

                if (tablaIngresoInformacion.Rows.Count == 1)
                {

                    MessageBox.Show("No existen datos relacionados con el ID", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCedulaJuridica.Text = "";
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

            PB_ProveedoresTransacciones objetoMostrar = new PB_ProveedoresTransacciones();

            try
            {

                if (txtCedulaJuridicaReporte.Text != "" && txtFechaInicio.CustomFormat != " " && txtFechaFinal.CustomFormat != " ") {

                    MessageBox.Show("No se pudo encontrar los datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtCedulaJuridicaReporte.Text == "" && txtFechaInicio.CustomFormat == " " && txtFechaFinal.CustomFormat == " ") {

                    MessageBox.Show("No se pudo encontrar los datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtFechaInicio.CustomFormat == " " && txtFechaFinal.CustomFormat != " " || txtFechaInicio.CustomFormat != " " && txtFechaFinal.CustomFormat == " ") {

                    MessageBox.Show("No se pudo encontrar los datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtCedulaJuridicaReporte.Text != "")
                {
                    idProveedor = txtCedulaJuridicaReporte.Text;
                    tablaIngresoInformacion.DataSource = objetoMostrar.Buscar(idProveedor);

                    tablaReportes.DataSource = objetoMostrar.ReporteProveedorPorCedula(idProveedor);

                    txtTotalReporte.Text = tablaReportes.CurrentRow.Cells["SumaMonto"].Value.ToString();

                    if (tablaIngresoInformacion.Rows.Count == 1)
                    {

                        MessageBox.Show("No existen datos relacionados con el ID", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCedulaJuridicaReporte.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCedulaJuridicaReporte.Text = "";
                    }
                }
                else if (txtFechaInicio.CustomFormat != " " && txtFechaFinal.CustomFormat != " ")
                {


                    tablaIngresoInformacion.DataSource = objetoMostrar.BuscarPorFechas(txtFechaInicio.Text, txtFechaFinal.Text);

                    tablaReportes.DataSource = objetoMostrar.ReporteProveedorPorFecha(txtFechaInicio.Text, txtFechaFinal.Text);

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
            txtCedulaJuridicaReporte.Clear();
            txtFechaInicio.CustomFormat = " ";
            txtFechaFinal.CustomFormat = " "; 
            txtTotalReporte.Clear();
        }

        //METODOS
        private void Limpiar()
        {

            if (txtCedulaJuridica.Enabled == false)
            {

                txtDescripcion.Text = "";
                txtFecha.CustomFormat = " ";
                txtMonto.Clear();

            }
            else
            {
                txtCedulaJuridica.Clear();
                txtDescripcion.Text = "";
                txtFecha.CustomFormat = " ";
                txtMonto.Clear();
            }

        }

        //VALIDACIONES 
       private void txtCedulaJuridicaIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
           Validaciones.soloNumeros(e);
        }

        private void txtCedulaJuridicaReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private bool validarCamposVacios()
        {

            bool datosVacios = false;

            if (txtCedulaJuridica.Text == "" | txtDescripcion.Text == "" | txtFecha.Text == "" | txtMonto.Text == "")
            {
                datosVacios = true;
            }

            return datosVacios;

        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {            
            txtFecha.CustomFormat = "dd/MM/yyyy";

            if (txtFecha.Value > DateTime.Today) {

                MessageBox.Show("Fecha no válida." , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            ProveedoresConsulta proveedoresConsulta = new ProveedoresConsulta();

            proveedoresConsulta.ShowDialog();

            txtCedulaJuridica.Text = proveedoresConsulta.idProveedorBuscar;
        }

        private void btnBuscarProveedor2_Click(object sender, EventArgs e)
        {
            ProveedoresConsulta proveedoresConsulta = new ProveedoresConsulta();

            proveedoresConsulta.ShowDialog();

            txtCedulaJuridicaReporte.Text = proveedoresConsulta.idProveedorBuscar;

        }
    }
       
    }
    

