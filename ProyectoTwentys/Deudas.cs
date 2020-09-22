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
    public partial class panelContenedor : Form
    {
        PB_Deudas objeto = new PB_Deudas();
        private bool Editar = false;
        string idEmpleado = null;
        string idDeudas = null;

       

        public panelContenedor()
        {
            InitializeComponent();
        }

        
        private void Deudas_Load(object sender, EventArgs e)
        {
            Mostrar();
            tablaReportes.Visible = false;
            txtTotalReporte.Enabled = false;
        }


        //MOSTRAR
        private void Mostrar()
        {
            PB_Deudas objetoMostrar = new PB_Deudas();
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
                        objeto.Insertar( txtIDEmpleado.Text, txtDescripcion.Text,  txtMonto.Text, txtEstado.Text);
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
                        objeto.Actualizar(idDeudas, txtIDEmpleado.Text, txtDescripcion.Text, txtMonto.Text, txtEstado.Text);
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

                idDeudas = tablaIngresoInformacion.CurrentRow.Cells["idDeuda"].Value.ToString();
                txtIDEmpleado.Text = tablaIngresoInformacion.CurrentRow.Cells["idEmpleado"].Value.ToString();
                txtDescripcion.Text = tablaIngresoInformacion.CurrentRow.Cells["descripcion"].Value.ToString();  
                txtMonto.Text = tablaIngresoInformacion.CurrentRow.Cells["monto"].Value.ToString();
                txtEstado.Text = tablaIngresoInformacion.CurrentRow.Cells["estado"].Value.ToString();
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
                idDeudas = tablaIngresoInformacion.CurrentRow.Cells["idDeudas"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    objeto.Eliminar(idEmpleado, idDeudas);
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
            PB_Deudas objetoMostrar = new PB_Deudas();


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

            PB_Deudas objetoMostrar = new PB_Deudas();

          
               if (txtIDEmpleadoReporte.Text != "")
                {
                    idEmpleado = txtIDEmpleadoReporte.Text;
                    tablaIngresoInformacion.DataSource = objetoMostrar.Buscar(idEmpleado);

                    tablaReportes.DataSource = objetoMostrar.ReporteDeudasPorEmpleado(idEmpleado);

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


        private void btnLimpiarReportesPorID_Click(object sender, EventArgs e)
        {
            txtIDEmpleadoReporte.Clear();
            txtTotalReporte.Clear();
        }

        //METODOS
        private void Limpiar()
        {

            if (txtIDEmpleado.Enabled == false)
            {

                txtDescripcion.Text = "";
                txtMonto.Clear();
                txtEstado.Text = "";

            }
            else
            {
                txtIDEmpleado.Clear();
                txtDescripcion.Text = "";
                txtMonto.Clear();
                txtEstado.Text = "";
            }

        }

        //VALIDACIONES 
       
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtIDEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloLetras(e);
        }

        private void txtIDEmpleadoReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }



        private bool validarCamposVacios()
        {

            bool datosVacios = false;

            if ( txtDescripcion.Text == "" | txtEstado.Text == "" | txtMonto.Text == "")
            {
                datosVacios = true;
            }

            return datosVacios;

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

            txtIDEmpleado.Text = empleadosConsulta.idEmpleadoBuscar;

        }

      
        private void btnBonos_Click(object sender, EventArgs e)
        {

        }
    }
}
