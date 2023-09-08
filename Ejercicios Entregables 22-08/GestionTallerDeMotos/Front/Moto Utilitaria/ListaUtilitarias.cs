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
    public partial class ListaUtilitarias : Form
    {
        public ListaUtilitarias()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        private void ListaUtilitarias_Load(object sender, EventArgs e)
        {
            dgvUtilitarias.DataSource = Principal.ObtenerMotosUtilitarias();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaUtilitaria altaUtilitaria = new AltaUtilitaria();
            altaUtilitaria.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            object idMotoElegida = this.dgvUtilitarias.SelectedCells[0].Value;
            int IdSelecciona = (int)idMotoElegida;

            Utilitaria moto_Elegida = (Utilitaria)dgvUtilitarias.CurrentRow.DataBoundItem;

            if (moto_Elegida != null)
            {
                var confirmacion = MessageBox.Show($"Seguro que desea eliminar esta motocicleta?\n Moto: {moto_Elegida.Marca} {moto_Elegida.Modelo}" +
                   $"\nUso: {moto_Elegida.Uso}", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.BajaMotoUtilitaria(moto_Elegida);
                }

            }
            else
            {
                MessageBox.Show("No hay ninguna moto seleccionado");
            }

            dgvUtilitarias.DataSource = null;

            dgvUtilitarias.DataSource = Principal.ObtenerMotosUtilitarias();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUtilitario modificacionUtili = new ModificarUtilitario();
            Utilitaria moto_Elegida = (Utilitaria)dgvUtilitarias.CurrentRow.DataBoundItem;
            modificacionUtili.RellenarInfo(moto_Elegida);
            modificacionUtili.Show();
            this.Hide();

            dgvUtilitarias.DataSource = null; // Eliminar el origen de datos actual
            dgvUtilitarias.DataSource = Principal.ObtenerMotosDepor(); // Asignar la lista actualizada
            dgvUtilitarias.Refresh();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
