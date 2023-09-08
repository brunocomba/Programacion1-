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
    public partial class ListaTele : Form
    {
        public ListaTele()
        {
            InitializeComponent();
        }

        private void ListaTele_Load(object sender, EventArgs e)
        {
            dgvTelevisores.DataSource = Principal.ObtenerTelevisores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaTele tele = new AltaTele();
            tele.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            object tele = this.dgvTelevisores.SelectedCells[0].Value;
            int IdCTeleElegido = (int)tele;


            Televisor tele_Elegido = (Televisor)dgvTelevisores.CurrentRow.DataBoundItem;

            if (tele_Elegido != null)
            {
                var confirmacion = MessageBox.Show($"Seguro que desea eliminar este smartphone del registro?\n \n Marca: {tele_Elegido.Marca}\n Modelo: {tele_Elegido.Modelo}" +
                   $"\n Pulgadas: {tele_Elegido.Pulgadas}\n Precio: {tele_Elegido.Precio}", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.BajaTele(tele_Elegido);
                }

            }
            else
            {
                MessageBox.Show("No hay ningun smartphone seleccionado");
            }

            dgvTelevisores.DataSource = null;

            dgvTelevisores.DataSource = Principal.ObtenerTelevisores();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificacionTele modTele = new ModificacionTele();

            Televisor tele_Elegido = (Televisor)dgvTelevisores.CurrentRow.DataBoundItem;
            modTele.RellenarInfo(tele_Elegido);
            modTele.Show();
            this.Hide();

            dgvTelevisores.DataSource = null; // Eliminar el origen de datos actual
            dgvTelevisores.DataSource = Principal.ObtenerSmartphones(); // Asignar la lista actualizada
            dgvTelevisores.Refresh();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); 
            menu.Show();
            this.Hide();
        }
    }
}
