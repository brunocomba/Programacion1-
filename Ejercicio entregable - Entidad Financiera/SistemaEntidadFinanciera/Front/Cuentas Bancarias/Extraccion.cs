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
    public partial class Extraccion : Form
    {
        public Extraccion()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            Cliente titular = (Cliente)cmboxTitular.SelectedItem;
            Cuenta_Bancaria cuenta = (Cuenta_Bancaria)cmboxCuenta.SelectedItem;

            var confir = MessageBox.Show($"Seguro desea realizar la siguiente extraccion?\n\nTitular cuenta: {titular.Nombre} {titular.Apellido}\nDNI: {titular.DNI}\nNro cuente: {cuenta.NroCuenta}\n" +
                $"Importe extraccion: {txtImporte.Text}", "CONFIRMAR",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confir == DialogResult.OK)
            {
                principal.RealizarExtraccion(cuenta, decimal.Parse(txtImporte.Text));

                MessageBox.Show($"La extraccion fue realizada con exito.\n\nEl saldo actual de la cuenta: {cuenta.NroCuenta} es de: ${cuenta.Saldo}");

            }
            else
            {
            }
        }

        private void Extraccion_Load(object sender, EventArgs e)
        {
            cmboxTitular.DataSource = principal.ObtenerClientesActivos();

        }

        private void cmboxTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmboxTitular.SelectedItem;

            var cuentasFiltaradas = principal.CuentasDeUnCliente(cliente);
            cmboxCuenta.DataSource = cuentasFiltaradas;
            cmboxCuenta.DisplayMember = "NroCuenta";
        }
    }
}
