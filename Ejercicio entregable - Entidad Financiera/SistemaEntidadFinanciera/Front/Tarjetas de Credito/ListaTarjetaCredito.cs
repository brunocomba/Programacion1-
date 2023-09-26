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

namespace Front.Tarjetas_de_Credito
{
    public partial class ListaTarjetaCredito : Form
    {
        public ListaTarjetaCredito()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        private void ListaTarjetaCredito_Load(object sender, EventArgs e)
        {
            DataTable resultado = principal.ListadoCompletoTarjetas();

            dgvTarjetaDeCredito.DataSource = resultado;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnNuevaTarjeta_Click(object sender, EventArgs e)
        {
            AltaTarjetaCredito altaTarjetaCredito = new AltaTarjetaCredito(this);
            altaTarjetaCredito.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTarjetaDeCredito.Rows.Count > 0)
            {
                Tarjeta_Credito tarjetaElegida = (Tarjeta_Credito)dgvTarjetaDeCredito.CurrentRow.DataBoundItem;
                var confirmacion = MessageBox.Show($"Seguro que desea dar de baja la siguiente tarjeta?\n\nNumero tarjeta: {tarjetaElegida.NroTarjeta}\nTitular: {tarjetaElegida.Cliente.Nombre} {tarjetaElegida.Cliente.Apellido}"
                    , "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.BajaTarjeta(tarjetaElegida);
                }
            }
            else
            {
                MessageBox.Show("No hay tarjetas registradas para dar de baja.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
