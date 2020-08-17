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
    public partial class Proveedores : Form
    {

        PB_Proveedores objeto = new PB_Proveedores();
        private bool Editar = false;
        private bool EditarIngreso = false;
        string idProveedor = null;
        string idTransaccion = null;

        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            Mostrar();
            MostrarIngreso();
            tabla3.Visible = false;
            txtTotalReportePorCedula.Enabled = false;
            txtTotalReportePorFecha.Enabled = false;
        }


        //MOSTRAR
        private void Mostrar()
        {

            PB_Proveedores objetoMostrar = new PB_Proveedores();
            tabla.DataSource = objetoMostrar.Mostrar();
        }

        private void MostrarIngreso()
        {

            PB_Proveedores objetoMostrar = new PB_Proveedores();
            tabla2.DataSource = objetoMostrar.MostrarIngreso();
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
                        objeto.Insertar(txtCedulaJuridica.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text);
                        MessageBox.Show("Se insertó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
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
                        objeto.Actualizar(txtCedulaJuridica.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text);
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

        private void btnAceptarIngreso_Click(object sender, EventArgs e)
        {
            if (EditarIngreso == false)
            {
                try
                {
                    if (validarCamposVaciosIngreso() == true)
                    {
                        MessageBox.Show("No se ingresaron bien los datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        objeto.InsertarIngreso(txtCedulaJuridicaIngreso.Text, txtDescripcion.Text, txtFecha.Text, txtMonto.Text);
                        MessageBox.Show("Se insertó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarIngreso();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (EditarIngreso == true)
            {

                try
                {
                    if (validarCamposVaciosIngreso() == true)
                    {
                        MessageBox.Show("No se ingresaron bien los datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        objeto.ActualizarIngreso(idTransaccion, txtCedulaJuridicaIngreso.Text, txtDescripcion.Text, txtFecha.Value, txtMonto.TextLength);
                        MessageBox.Show("Se editó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarIngreso();
                        EditarIngreso = false;
                        txtCedulaJuridicaIngreso.Enabled = true;
                        LimpiarIngreso();
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
            if (tabla.SelectedRows.Count > 0)
            {
                Editar = true;
                   
                    txtCedulaJuridica.Text = tabla.CurrentRow.Cells["idProveedor"].Value.ToString();
                    txtNombre.Text = tabla.CurrentRow.Cells["nombre"].Value.ToString();
                    txtTelefono.Text = tabla.CurrentRow.Cells["telefono"].Value.ToString();
                    txtDireccion.Text = tabla.CurrentRow.Cells["direccion"].Value.ToString();
                    txtCedulaJuridica.Enabled = false;
            }
            else 
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnActualizarIngreso_Click(object sender, EventArgs e)
        {

            if (tabla2.SelectedRows.Count > 0)
            {
                EditarIngreso = true;

                idTransaccion = tabla2.CurrentRow.Cells["idTransaccion"].Value.ToString();
                txtCedulaJuridicaIngreso.Text = tabla2.CurrentRow.Cells["idProveedor"].Value.ToString();
                txtDescripcion.Text = tabla2.CurrentRow.Cells["descripcion"].Value.ToString();
                txtFecha.Text = tabla2.CurrentRow.Cells["fecha"].Value.ToString();
                txtMonto.Text = tabla2.CurrentRow.Cells["monto"].Value.ToString();
                txtCedulaJuridicaIngreso.Enabled = false;
            }
            else
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        //ELIMINAR 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                idProveedor = tabla.CurrentRow.Cells["idProveedor"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    objeto.Eliminar(idProveedor);
                    //MessageBox.Show("Se eliminó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                }              
                
            }
            else
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {

            if (tabla2.SelectedRows.Count > 0)
            {
                idProveedor = tabla2.CurrentRow.Cells["idProveedor"].Value.ToString();
                idTransaccion = tabla2.CurrentRow.Cells["idTransaccion"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    objeto.EliminarIngreso(idProveedor, idTransaccion);
                    MessageBox.Show("Se eliminó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarIngreso();
                }

            }
            else
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        //BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            PB_Proveedores objetoMostrar = new PB_Proveedores();
            

            if (txtCedulaJuridica.Text != "")
            {
                idProveedor = txtCedulaJuridica.Text;
                tabla.DataSource = objetoMostrar.Buscar(idProveedor);

                if (tabla.Rows.Count == 1)
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

        private void btnBuscarIngreso_Click(object sender, EventArgs e)
        {
            PB_Proveedores objetoMostrar = new PB_Proveedores();


            if (txtCedulaJuridicaIngreso.Text != "")
            {
                idProveedor = txtCedulaJuridicaIngreso.Text;
                tabla2.DataSource = objetoMostrar.BuscarIngreso(idProveedor);

                if (tabla2.Rows.Count == 1)
                {

                    MessageBox.Show("No existen datos relacionados con el ID", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCedulaJuridicaIngreso.Text = "";
                }
                else
                {
                    MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Ingrese el ID", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //LIMPIAR 
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnLimpiarIngreso_Click(object sender, EventArgs e)
        {
            LimpiarIngreso();
        }

        private void btnLimpiarIngreso2_Click(object sender, EventArgs e)
        {
            MostrarIngreso();
        }

       
        private void btnLimpiarReportesPorCedula_Click(object sender, EventArgs e)
        {
            txtCedulaJuridicaReporte.Clear();
            txtTotalReportePorCedula.Clear();
        }

        private void btnLimpiarReportesPorFecha_Click(object sender, EventArgs e)
        {
            dateFechaInicio.ResetText();
            dateFechaFinal.ResetText();
            txtTotalReportePorFecha.Clear();
        }

        //METODOS
        private void Limpiar()
        {

            if (txtCedulaJuridica.Enabled == false)
            {

                txtNombre.Text = "";
                txtTelefono.Clear();
                txtDireccion.Text = "";

            }
            else
            {
                txtNombre.Text = "";
                txtTelefono.Clear();
                txtDireccion.Text = "";
                txtCedulaJuridica.Clear();
            }

        }

        private void LimpiarIngreso()
        {

            if (txtCedulaJuridicaIngreso.Enabled == false)
            {

                txtDescripcion.Text = "";
                txtFecha.ResetText();
                txtMonto.Clear();

            }
            else
            {
                txtCedulaJuridicaIngreso.Clear();
                txtDescripcion.Text = "";
                txtFecha.ResetText();
                txtMonto.Clear();
            }

        }


        //VALIDACIONES 
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtCedulaJuridica_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtCedulaJuridicaIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtCedulaJuridicaReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }


        private void soloLetras(KeyPressEventArgs e) 
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsSeparator(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void soloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private bool validarCamposVacios() {

            bool datosVacios = false; 

                if (txtCedulaJuridica.Text == "" | txtNombre.Text == "" | txtTelefono.Text == "" | txtDireccion.Text == "")
                {
                    datosVacios = true; 
                }

            return datosVacios;

        }

        private bool validarCamposVaciosIngreso()
        {

            bool datosVacios = false;

            if (txtCedulaJuridicaIngreso.Text == "" | txtDescripcion.Text == "" | txtFecha.Text == "" | txtMonto.Text == "")
            {
                datosVacios = true;
            }

            return datosVacios;

        }


        //REPORTES 
        private void btnAceptarReportesPorCedula_Click(object sender, EventArgs e)
        {
            PB_Proveedores objetoMostrar = new PB_Proveedores();

         if (txtCedulaJuridicaReporte.Text != "")
            {
                idProveedor = txtCedulaJuridicaReporte.Text;
                tabla2.DataSource = objetoMostrar.BuscarIngreso(idProveedor); 
                
                tabla3.DataSource = objetoMostrar.ReporteProveedorPorCedula(idProveedor);

                txtTotalReportePorCedula.Text = tabla3.CurrentRow.Cells["SumaMonto"].Value.ToString();

                if (tabla2.Rows.Count == 1)
                {

                    MessageBox.Show("No existen datos relacionados con el ID", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCedulaJuridicaReporte.Text = "";
                }
                else
                {
                    MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Ingrese el ID", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAceptarReportesPorFecha_Click(object sender, EventArgs e)
        {

            PB_Proveedores objetoMostrar = new PB_Proveedores();

                
                tabla2.DataSource = objetoMostrar.BuscarPorFechas(dateFechaInicio.Text, dateFechaFinal.Text);

                tabla3.DataSource = objetoMostrar.ReporteProveedorPorFecha(dateFechaInicio.Text, dateFechaFinal.Text);

                txtTotalReportePorFecha.Text = tabla3.CurrentRow.Cells["SumaMonto"].Value.ToString();

                if (tabla2.Rows.Count == 1)
                {

                    MessageBox.Show("No existen datos relacionados con las fechas ingresadas", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCedulaJuridicaReporte.Text = "";
                }
                else
                {
                    MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            

        }

        
    }
    

