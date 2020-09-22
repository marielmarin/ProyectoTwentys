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
    public partial class Empleados : Form
    {
        PB_Empleados objeto = new PB_Empleados();
        private bool Editar = false;
        string idEmpleado = null;

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Mostrar();
        }


        //MOSTRAR
        private void Mostrar()
        {

            PB_Empleados objetoMostrar = new PB_Empleados();
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
                        objeto.Insertar( txtNombre.Text, txtCorreo.Text, txtTelefono.Text, txtPagoPorHora.Text, txtSalarioMinimo.Text, txtPuesto.Text);
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
                        objeto.Actualizar(idEmpleado, txtNombre.Text, txtCorreo.Text, txtTelefono.Text, txtPagoPorHora.Text, txtSalarioMinimo.Text, txtPuesto.Text);
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

                idEmpleado = tabla.CurrentRow.Cells["idEmpleado"].Value.ToString();
                txtNombre.Text = tabla.CurrentRow.Cells["nombre"].Value.ToString();
                txtTelefono.Text = tabla.CurrentRow.Cells["telefono"].Value.ToString();
                txtCorreo.Text = tabla.CurrentRow.Cells["correo"].Value.ToString();
                txtPagoPorHora.Text = tabla.CurrentRow.Cells["pagoPorHora"].Value.ToString();
                txtSalarioMinimo.Text = tabla.CurrentRow.Cells["salarioMinimo"].Value.ToString();
                txtPuesto.Text = tabla.CurrentRow.Cells["puesto"].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //ELIMINAR 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                idEmpleado = tabla.CurrentRow.Cells["idEmpleado"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    objeto.Eliminar(idEmpleado);
                    //MessageBox.Show("Se eliminó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                }

            }
            else
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            PB_Empleados objetoMostrar = new PB_Empleados();


            if (txtNombre.Text != "")
            {
                tabla.DataSource = objetoMostrar.Buscar(txtNombre.Text);

                if (tabla.Rows.Count == 1)
                {
                    MessageBox.Show("No existen datos relacionados con el nombre", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtNombre.Text = "";
                }

                else
                {
                    MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Ingrese el nombre del proveedor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        //METODOS
        private void Limpiar()
        {         
                txtNombre.Text = "";
                txtTelefono.Clear();
                txtCorreo.Text = "";
                txtPagoPorHora.Clear();
                txtSalarioMinimo.Clear();
                txtPuesto.Text = "";

        }

        //VALIDACIONES 
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloLetras(e);
        }

        private void txtSalarioMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtPagoPorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }


        private bool validarCamposVacios()
        {

            bool datosVacios = false;

            if (txtNombre.Text == "" | txtTelefono.Text == "" | txtCorreo.Text == "" | txtPuesto.Text == "" | txtSalarioMinimo.Text == "" | txtPagoPorHora.Text == "")
            {
                datosVacios = true;
            }

            return datosVacios;

        }
    }
}
