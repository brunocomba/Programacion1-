using Back.Clases;
using Front.INICIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Clientes
{
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();

        }
        Principal principal = new Principal();
        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = principal.ObtenerClientes();
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            AltaCliente cliente = new AltaCliente(this);
            cliente.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                Cliente cliente_Elegido = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                var confirmacion = MessageBox.Show($"Seguro que desea eliminar el siguiente cliento?\nNombre: {cliente_Elegido.Nombre} {cliente_Elegido.Apellido}\nDNI: {cliente_Elegido.DNI}"
                    , "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.EliminarCliente(cliente_Elegido);
                }
            }
            else
            {
                MessageBox.Show("No hay clientes registrados para eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
