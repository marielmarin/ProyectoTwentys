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
    public partial class CuentasPorCobrarConsulta : Form
    {

        PB_CuentasPorCobrar objeto = new PB_CuentasPorCobrar();
        public string idCuentasPorCobrarBuscar = null;

        public CuentasPorCobrarConsulta()
        {
            InitializeComponent();
        }

        private void CuentasPorCobrarConsulta_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        //MOSTRAR
        private void Mostrar()
        {

            PB_CuentasPorCobrar objetoMostrar = new PB_CuentasPorCobrar();
            tabla.DataSource = objetoMostrar.Mostrar();

            
           
        }
  
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloLetras(e);
        }

        //BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            

            PB_CuentasPorCobrar objetoMostrar = new PB_CuentasPorCobrar();

            

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
  
                idCuentasPorCobrarBuscar = tabla.CurrentRow.Cells["idCuentasPorCobrar"].Value.ToString();

                this.Close();
            }

            }

       
    }

        
    }
    

