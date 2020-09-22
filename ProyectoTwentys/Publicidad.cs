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
    public partial class Publicidad : Form
    {
        PB_Publicidad objeto = new PB_Publicidad();
        private bool Editar = false;
        string idPublicidad = null;


        public Publicidad()
        {
            InitializeComponent();
        }

        private void Publicidad_Load(object sender, EventArgs e)
        {
            Mostrar();
            tablaReportes.Visible = false;
            txtTotalReporte.Enabled = false;
        }


        //MOSTRAR
        private void Mostrar()
        {
            PB_Publicidad objetoMostrar = new PB_Publicidad();
            tabla.DataSource = objetoMostrar.Mostrar();
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
                        objeto.Insertar(txtDescripcion.Text, txtFecha.Text, txtMonto.Text);
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
                        objeto.Actualizar(idPublicidad, txtDescripcion.Text, txtFecha.Value, txtMonto.Text);
                        MessageBox.Show("Se editó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                        Editar = false;
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

            if (tabla.SelectedRows.Count > 0)
            {
                Editar = true;

                idPublicidad = tabla.CurrentRow.Cells["idPublicidad"].Value.ToString();
                txtDescripcion.Text = tabla.CurrentRow.Cells["descripcion"].Value.ToString();
                txtFecha.Text = tabla.CurrentRow.Cells["fecha"].Value.ToString();
                txtMonto.Text = tabla.CurrentRow.Cells["monto"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        //ELIMINAR 
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (tabla.SelectedRows.Count > 0)
            {
                idPublicidad = tabla.CurrentRow.Cells["idPublicidad"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    objeto.Eliminar(idPublicidad);
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
            PB_Publicidad objetoMostrar = new PB_Publicidad();


            if (txtDescripcion.Text != "")
            {
                
                tabla.DataSource = objetoMostrar.Buscar(txtDescripcion.Text);

                if (tabla.Rows.Count == 1)
                {

                    MessageBox.Show("No existen datos relacionados con la descripción", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripcion.Text = "";
                }
                else
                {
                    MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Ingrese descripción", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //REPORTES 
        private void btnAceptarReportes_Click(object sender, EventArgs e)
        {

            PB_Publicidad objetoMostrar = new PB_Publicidad();

            try
            {

                if (txtDescripcionReporte.Text != "" && txtFechaInicio.CustomFormat != " " && txtFechaFinal.CustomFormat != " ")
                {

                    MessageBox.Show("No se pudo encontrar los datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtDescripcionReporte.Text == "" && txtFechaInicio.CustomFormat == " " && txtFechaFinal.CustomFormat == " ")
                {

                    MessageBox.Show("No se pudo encontrar los datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtFechaInicio.CustomFormat == " " && txtFechaFinal.CustomFormat != " " || txtFechaInicio.CustomFormat != " " && txtFechaFinal.CustomFormat == " ")
                {

                    MessageBox.Show("No se pudo encontrar los datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtDescripcionReporte.Text != "")
                {
                    
                    tabla.DataSource = objetoMostrar.Buscar(txtDescripcionReporte.Text);

                    tablaReportes.DataSource = objetoMostrar.ReportePublicidadPorDescripcion(txtDescripcionReporte.Text);

                    txtTotalReporte.Text = tablaReportes.CurrentRow.Cells["SumaMonto"].Value.ToString();

                    if (tabla.Rows.Count == 1)
                    {

                        MessageBox.Show("No existen datos relacionados con la descripción", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDescripcionReporte.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDescripcionReporte.Text = "";
                    }
                }
                else if (txtFechaInicio.CustomFormat != " " && txtFechaFinal.CustomFormat != " ")
                {


                    tabla.DataSource = objetoMostrar.BuscarPublicidadPorFecha(txtFechaInicio.Text, txtFechaFinal.Text);

                    tablaReportes.DataSource = objetoMostrar.ReportePublicidadPorFecha(txtFechaInicio.Text, txtFechaFinal.Text);

                    txtTotalReporte.Text = tablaReportes.CurrentRow.Cells["SumaMonto"].Value.ToString();

                    if (tabla.Rows.Count == 1)
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


        private void btnLimpiarReportes_Click(object sender, EventArgs e)
        {
            txtDescripcionReporte.Clear();
            txtFechaInicio.CustomFormat = " ";
            txtFechaFinal.CustomFormat = " ";
            txtTotalReporte.Clear();
        }

        //METODOS
        private void Limpiar()
        {
                txtDescripcion.Text = "";
                txtFecha.CustomFormat = " ";
                txtMonto.Clear();
            
        }

        //VALIDACIONES 
        
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private bool validarCamposVacios()
        {

            bool datosVacios = false;

            if (txtDescripcion.Text == "" | txtDescripcion.Text == "" | txtFecha.Text == "" | txtMonto.Text == "")
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

       
    }
}
