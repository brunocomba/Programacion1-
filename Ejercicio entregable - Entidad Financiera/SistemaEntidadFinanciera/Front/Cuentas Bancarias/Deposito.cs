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
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Cliente titular = (Cliente)cmboxTitular.SelectedItem;
            Cuenta_Bancaria cuenta = (Cuenta_Bancaria)cmboxCuenta.SelectedItem;

            var confir = MessageBox.Show($"Seguro desea realizar el desposito?\n\nTitular cuenta: {titular.Nombre}\nApellido: {titular.Apellido}\nDNI: {titular.DNI}\nNro cuente: {cuenta.NroCuenta}\n" +
                $"Importe: {txtImporte.Text}", "CONFIRMAR",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confir == DialogResult.OK)
            {
                principal.RealizarDeposito(cuenta, decimal.Parse(txtImporte.Text));

                MessageBox.Show($"El deposito se realizado exitosamente.\n\nEl saldo actual de la cuenta: {cuenta.NroCuenta} es de: ${cuenta.Saldo}");

            }
            else
            {
            }
        }

        private void Deposito_Load(object sender, EventArgs e)
        {
            cmboxTitular.DataSource = principal.ObtenerClientesActivos();

        }

        private void cmboxTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmboxTitular.SelectedItem;

            var cuentasFiltaradas = principal.FiltrarCuentasPorClientes(cliente);
            cmboxCuenta.DataSource = cuentasFiltaradas;
            cmboxCuenta.DisplayMember = "NroCuenta";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
