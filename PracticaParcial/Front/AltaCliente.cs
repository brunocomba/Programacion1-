using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Logica.Clases;

namespace Front

{
    public partial class AltaCliente : Form
    {
        Principal principal = new Principal();
        ClientesMenu clientesMenu = new ClientesMenu();


        public AltaCliente()
        {
            InitializeComponent();
        }
        private Cliente ClienteQueEdito;
        public void EditarCliente(Cliente unCliente)
        {
            ClienteQueEdito = unCliente;
            txtID.Text = ClienteQueEdito.id.ToString();
            txtID.Enabled = false;
            txtDNI.Text = ClienteQueEdito.dni.ToString();
            txtNombre.Text = ClienteQueEdito.nombre;
            txtApellido.Text = ClienteQueEdito.apellido;
        }

        private void HacemeElAlta()
        {
            Cliente clienteNew = new Cliente();
            clienteNew.dni = int.Parse(txtDNI.Text);
            clienteNew.nombre = txtNombre.Text;
            clienteNew.apellido = txtApellido.Text;

            Principal.ObtenerClientes().Add(clienteNew);

            MessageBox.Show("Cliente agregado con exito");

        }
        private void btnAregarCliente_Click(object sender, EventArgs e)
        {
            if (ClienteQueEdito == null)
            {
                // NO estoy editanto, estoy creando uno nuevo
                principal.AltaCliente(int.Parse(txtID.Text), int.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text);

                MessageBox.Show("Cliente agregado con exito");

                var confirmacion = MessageBox.Show("Desea agregar otro cliente?  ", "ATENCION!", MessageBoxButtons.OKCancel);
                if (confirmacion == DialogResult.OK)
                {
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDNI.Text = "";
                }
                else
                {
                    ClientesMenu clientesMenu = new ClientesMenu();
                    clientesMenu.Show();
                    this.Hide();
                }
            }
            else
            {
                // Tengo un valor a editar.
                var SIoNO = MessageBox.Show("Seguro desea realizar esta modificacion? ", "ATENCION!", MessageBoxButtons.OKCancel);
                if (SIoNO == DialogResult.OK)
                {
                    principal.modificarCliente(ClienteQueEdito, int.Parse(txtID.Text),
                    int.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text);

                    MessageBox.Show("Cliente modificado con exito!");
                    clientesMenu.Show();
                    this.Hide();
                }
                else
                {
                    clientesMenu.Show();
                    this.Hide();
                }

            }




            //HacemeElAlta();
            /*
            Cliente clienteNew = new Cliente();
            clienteNew.dni = int.Parse(txtDNI.Text);
            clienteNew.nombre = txtNombre.Text;
            clienteNew.apellido = txtApellido.Text;

            principal.AgregarCliente(clienteNew);

            MessageBox.Show("Cliente agregado con exito");

            
            dataGridView1.DataSource = null; // Eliminar el origen de datos actual
            dataGridView1.DataSource = principal.ListaClientes; // Asignar la lista actualizada
            dataGridView1.Refresh();
            */
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ClientesMenu clientesMenu = new ClientesMenu();
            clientesMenu.Show();
            this.Hide();
        }

        private void AltaCliente_Load(object sender, EventArgs e)

        {


        }
    }
}
