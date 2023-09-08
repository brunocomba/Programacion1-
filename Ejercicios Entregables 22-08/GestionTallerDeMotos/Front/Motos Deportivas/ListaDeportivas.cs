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
    public partial class ListaDeportivas : Form
    {
        public ListaDeportivas()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        private void Lista_Load(object sender, EventArgs e)
        {
            dgvDeportivas.DataSource = Principal.ObtenerMotosDepor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaDeportiva alta = new AltaDeportiva();
            alta.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           //object idMotoElegida = this.dgvDeportivas.SelectedCells[0].Value;
            //int IdSelecciona = (int)idMotoElegida;

            Deportiva moto_Elegida = (Deportiva)dgvDeportivas.CurrentRow.DataBoundItem;

            if (moto_Elegida != null)
            {
                var confirmacion = MessageBox.Show($"Seguro que desea eliminar esta motocicleta?\n Moto: {moto_Elegida.Marca} {moto_Elegida.Modelo}" +
                   $"\nCilindrada: {moto_Elegida.Cilindrada}", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.BajaMotoDepor(moto_Elegida);
                }

            }
            else
            {
                MessageBox.Show("No hay ninguna moto seleccionado");
            }

            dgvDeportivas.DataSource = null;

            dgvDeportivas.DataSource = Principal.ObtenerMotosDepor();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificacionDeportiva modificacion = new ModificacionDeportiva();
            Deportiva moto_Elegida = (Deportiva)dgvDeportivas.CurrentRow.DataBoundItem;
            modificacion.RellenarInfo(moto_Elegida);
            modificacion.Show();
            this.Hide();

            dgvDeportivas.DataSource = null; // Eliminar el origen de datos actual
            dgvDeportivas.DataSource = Principal.ObtenerMotosDepor(); // Asignar la lista actualizada
            dgvDeportivas.Refresh();
        }

        private void dgvDeportivas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }

}
