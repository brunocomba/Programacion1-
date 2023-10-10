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

namespace Front
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void Compra_Load(object sender, EventArgs e)
        {
            cmboxTitular.Items.AddRange(principal.ObtenerClientesActivos().ToArray());
            var compras = principal.Compras();

        }

        private void cmboxTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmboxTitular.SelectedItem;

            var tarjetasFiltradas = principal.TarjetasDeUnCliente(cliente);
            cmboxNroTarjeta.DataSource = null;
            cmboxNroTarjeta.DataSource = tarjetasFiltradas;
            cmboxNroTarjeta.DisplayMember = "NroTarjeta";
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Cliente titular = (Cliente)cmboxTitular.SelectedItem;
            Tarjeta_Credito tarjeta = (Tarjeta_Credito)cmboxNroTarjeta.SelectedItem;
            DateTime fecha = dateTimePicker1.Value;

            var confir = MessageBox.Show($"Seguro desea realizar la siguiente compra?\n\nCompra: {txtDetalle.Text}\nPrecio: {txtPrecio.Text}\n\nTitular tarjeta: {titular.Nombre} {titular.Apellido}\nDNI: {titular.DNI}\nNro tarjeta: {tarjeta.NroTarjeta}\n", "CONFIRMAR",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confir == DialogResult.OK)
            {
                principal.RealizarCompraConTarjeta(tarjeta, decimal.Parse(txtPrecio.Text), txtDetalle.Text, fecha.Date);

                MessageBox.Show($"La compra fue realizado con exito.\n\nEl saldo actual de la tarjeta: {tarjeta.NroTarjeta} es de: ${tarjeta.SaldoDisponible}");
                txtDetalle.Clear();
                txtPrecio.Clear();

            }
            else
            {

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
