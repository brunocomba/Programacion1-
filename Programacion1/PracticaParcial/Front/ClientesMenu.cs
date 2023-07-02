using Logica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class ClientesMenu : Form
    {
        public ClientesMenu()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        private void button1_Click(object sender, EventArgs e)
        {
            AltaCliente altaCliente = new AltaCliente();
            altaCliente.Show();
            this.Hide();

            dataGridView1.DataSource = null; // Eliminar el origen de datos actual
            dataGridView1.DataSource = Principal.ObtenerClientes(); // Asignar la lista actualizada
            dataGridView1.Refresh();


        }

        private void ClientesMenu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Principal.ObtenerClientes();
            //dataGridView1.DataSource = principal.ListaClientes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuInicio menuIni = new MenuInicio();
            menuIni.Show();
            this.Hide();
            dataGridView1.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Miro cual es el ID seleccionado en la grilla
            
            object IdElegido = this.dataGridView1.SelectedCells[0].Value;
            int idSeleccionado = (int)IdElegido;

           
            

            Cliente valor_Elegido = (Cliente)dataGridView1.CurrentRow.DataBoundItem;

            if (valor_Elegido != null)
            {
                var confirmacion = MessageBox.Show("Seguro que desea eliminar este cliente, con el ID " + idSeleccionado, "ADVERTENCIA", MessageBoxButtons.OKCancel);

                if (confirmacion == DialogResult.OK)
                {
                    principal.removeThisCliente(valor_Elegido);
                }
                
            }
            else
            {
                MessageBox.Show("No hay ningun cliente seleccionado");
            }

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = Principal.ObtenerClientes();

        }
    }
}
