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
    public partial class GastosExtraordinarios : Form
    {

        PB_GastosExtraordinarios objeto = new PB_GastosExtraordinarios();
        private bool Editar = false;
        string idGastosExtraordinarios = null;

        public GastosExtraordinarios()
        {
            InitializeComponent();
        }

        private void GastosExtraordinarios_Load(object sender, EventArgs e)
        {
            Mostrar();
            tablaReportes.Visible = false;
            txtTotalReporte.Enabled = false;
        }

        //MOSTRAR
        private void Mostrar()
        {
            PB_GastosExtraordinarios objetoMostrar = new PB_GastosExtraordinarios();
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
                        objeto.Insertar(txtDescripcion.Text, txtMonto.Text);
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
                        objeto.Actualizar(idGastosExtraordinarios, txtDescripcion.Text, txtMonto.Text);
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

            if (tablaIngresoInformacion.SelectedRows.Count > 0)
            {
                Editar = true;

                idGastosExtraordinarios = tablaIngresoInformacion.CurrentRow.Cells["idGastosExtraordinarios"].Value.ToString();
                txtDescripcion.Text = tablaIngresoInformacion.CurrentRow.Cells["descripcion"].Value.ToString();
                txtMonto.Text = tablaIngresoInformacion.CurrentRow.Cells["monto"].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        //ELIMINAR 
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (tablaIngresoInformacion.SelectedRows.Count > 0)
            {
                idGastosExtraordinarios = tablaIngresoInformacion.CurrentRow.Cells["idGastosExtraordinarios"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    objeto.Eliminar(idGastosExtraordinarios);
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
            PB_GastosExtraordinarios objetoMostrar = new PB_GastosExtraordinarios();


            if (txtDescripcion.Text != "")
            {

                tablaIngresoInformacion.DataSource = objetoMostrar.Buscar(txtDescripcion.Text);

                if (tablaIngresoInformacion.Rows.Count == 1)
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

            PB_GastosExtraordinarios objetoMostrar = new PB_GastosExtraordinarios();


            if (txtDescripcionReportes.Text != "")
            {

                tablaIngresoInformacion.DataSource = objetoMostrar.Buscar(txtDescripcionReportes.Text);

                tablaReportes.DataSource = objetoMostrar.ReportesGastosExtraordinarios(txtDescripcionReportes.Text);

                txtTotalReporte.Text = tablaReportes.CurrentRow.Cells["SumaMonto"].Value.ToString();

                if (tablaIngresoInformacion.Rows.Count == 1)
                {

                    MessageBox.Show("No existen datos relacionados con la descripción", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripcionReportes.Text = "";
                }
                else
                {
                    MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcionReportes.Text = "";
                }
            }
            else {

                MessageBox.Show("Ingrese datos requeridos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtDescripcionReportes.Text = "";
            txtTotalReporte.Clear();
        }

        //METODOS
        private void Limpiar()
        {
            txtDescripcion.Text = "";
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

            if (txtDescripcion.Text == "" | txtMonto.Text == "")
            {
                datosVacios = true;
            }

            return datosVacios;

        }
    }
}
