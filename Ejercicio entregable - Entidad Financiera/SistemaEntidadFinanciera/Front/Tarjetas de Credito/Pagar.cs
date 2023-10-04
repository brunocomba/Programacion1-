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

namespace Front.Tarjetas_de_Credito
{
    public partial class Pagar : Form
    {
        public Pagar()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        private void Pagar_Load(object sender, EventArgs e)
        {
            cmboxTitular.Items.AddRange(principal.ObtenerClientesActivos().ToArray());
        }

        private void cmboxTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmboxTitular.SelectedItem;

            var tarjetasFiltradas = principal.TarjetasDeUnCliente(cliente);
            cmboxNroTarjeta.DataSource = null;
            cmboxNroTarjeta.DataSource = tarjetasFiltradas;
            cmboxNroTarjeta.DisplayMember = "NroTarjeta";
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Cliente titular = (Cliente)cmboxTitular.SelectedItem;
            Tarjeta_Credito tarjeta = (Tarjeta_Credito)cmboxNroTarjeta.SelectedItem;

            var confir = MessageBox.Show($"Seguro desea realizar el siguiente pago?\nMonto pago: {txtMonto.Text}\n\nDatos tarjeta\nTitular tarjeta: {titular.Nombre} {titular.Apellido}\nDNI: {titular.DNI}\nNro tarjeta: {tarjeta.NroTarjeta}\n", "CONFIRMAR",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confir == DialogResult.OK)
            {
                principal.PagarTarjeta(tarjeta, decimal.Parse(txtMonto.Text));

                MessageBox.Show($"La compra fue realizado con exito.\n\nEl saldo actual de la tarjeta: {tarjeta.NroTarjeta} es de: ${tarjeta.SaldoDisponible}");
                txtMonto.Clear();

            }
            else
            {

            }
        }
    }
}
