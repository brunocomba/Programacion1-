using Back.Clases;
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
    public partial class ListaSmartphones : Form
    {
        public ListaSmartphones()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaSmartphone altaSmartphone = new AltaSmartphone();
            altaSmartphone.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void ListaSmartphones_Load(object sender, EventArgs e)
        {
            dgvSmartphones.DataSource = Principal.ObtenerSmartphones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            object celu = this.dgvSmartphones.SelectedCells[0].Value;
            int IdCeluElegido = (int)celu;

            Smartphone celu_Elegido = (Smartphone)dgvSmartphones.CurrentRow.DataBoundItem;

            if (celu_Elegido != null)
            {
                var confirmacion = MessageBox.Show($"Seguro que desea eliminar este smartphone del registro?\n \n Marca: {celu_Elegido.Marca}\n Modelo: {celu_Elegido.Modelo}" +
                   $"\n GB: {celu_Elegido.GbAlmacenamiento}\n Precio: {celu_Elegido.Precio}", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.BajaSmartphone(celu_Elegido);
                }

            }
            else
            {
                MessageBox.Show("No hay ningun smartphone seleccionado");
            }

            dgvSmartphones.DataSource = null;

            dgvSmartphones.DataSource = Principal.ObtenerSmartphones();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificacionSmartphone modSmartphone = new ModificacionSmartphone();

            Smartphone celu_Elegido = (Smartphone)dgvSmartphones.CurrentRow.DataBoundItem;
            modSmartphone.RellenarInfo(celu_Elegido);
            modSmartphone.Show();
            this.Hide();

            dgvSmartphones.DataSource = null; // Eliminar el origen de datos actual
            dgvSmartphones.DataSource = Principal.ObtenerSmartphones(); // Asignar la lista actualizada
            dgvSmartphones.Refresh();
        }
    }
}
