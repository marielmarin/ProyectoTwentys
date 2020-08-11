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
        string idProveedor = null;

        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            Mostrar();
        }


        //MOSTRAR
        private void Mostrar()
        {

            PB_Proveedores objetoMostrar = new PB_Proveedores();
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
                    MessageBox.Show("Se eliminó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                }              
                
            }
            else
                MessageBox.Show("Seleccione una fila, por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //BUSCAR
        private void btnBuscar3_Click(object sender, EventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        //LIMPIAR
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

            
        private void soloLetras(KeyPressEventArgs e) //ARREGLAR
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
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
    }
    
}
