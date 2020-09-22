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
    public partial class DeudasConsulta : Form
    {

        PB_Deudas objeto = new PB_Deudas();
        public string idDeudaBuscar = null;

        public DeudasConsulta()
        {
            InitializeComponent();
        }

        private void Deudas_Load(object sender, EventArgs e)
        {
            Mostrar();

        }

        //MOSTRAR
        private void Mostrar()
        {

            PB_Deudas objetoMostrar = new PB_Deudas();
            tabla.DataSource = objetoMostrar.Mostrar();

            
           
        }
  
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloLetras(e);
        }

        //BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            

            PB_Deudas objetoMostrar = new PB_Deudas();

            

            if (txtNombre.Text != "")
            {
                tabla.DataSource = objetoMostrar.Buscar(txtNombre.Text);

                if (tabla.Rows.Count == 1)
                {

                    MessageBox.Show("No existen datos relacionados con el proveedor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Text = "";
                }
                else
                {
                    MessageBox.Show("Se buscó correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
                MessageBox.Show("Ingrese el nombre", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnLimpiarTabla_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tabla_SelectionChanged(object sender, EventArgs e)
        {

            if (tabla.SelectedRows.Count > 0)
            {
  
                idDeudaBuscar = tabla.CurrentRow.Cells["idDeuda"].Value.ToString();

                this.Close();
            }

            }
    }

        
    }
    

