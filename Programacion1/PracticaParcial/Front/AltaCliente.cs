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
        public AltaCliente()
        {
            InitializeComponent();


        }
        Principal principal = new Principal();
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

            HacemeElAlta();
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
            /*
            dataGridView1.DataSource = principal.ListaClientes;
            */



        }
    }
}
