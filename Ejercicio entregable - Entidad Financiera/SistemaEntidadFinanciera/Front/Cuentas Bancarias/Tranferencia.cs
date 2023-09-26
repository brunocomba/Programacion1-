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
    public partial class Tranferencia : Form
    {
        public Tranferencia()
        {
            InitializeComponent();
        }



        Principal principal = new Principal();
        private void Tranferencia_Load(object sender, EventArgs e)
        {
            var listaCli = principal.ObtenerClientesActivos();
            cmboxTitular.Items.AddRange(listaCli.ToArray());

            cmboxTipoTransf.Items.Add("Entre cuentas propias");
            cmboxTipoTransf.Items.Add("A terceros");
            cmboxTipoTransf.Items.Add("Nuevo destinatario");


        }

        private void cmboxTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmboxTitular.SelectedItem;

            var cuentasFiltaradas = principal.CuentasDeUnCliente(cliente);
            cmboxCuentaOrigen.DataSource = cuentasFiltaradas;
        }

        private void cmboxTipoTransf_SelectedIndexChanged(object sender, EventArgs e)
        {

            Cliente cliente = (Cliente)cmboxTitular.SelectedItem;

            // la primera opcion ("Entre cuentas propias")
            if (cmboxTipoTransf.SelectedIndex == 0)
            {
                cmboxCuentaDestino.DataSource = principal.CuentasDeUnCliente(cliente);

            }
            // es igual a las segunda opcion
            else if (cmboxTipoTransf.SelectedIndex == 1)
            {
                cmboxCuentaDestino.DataSource = principal.CuentasAjenasAlCliente(cliente);
                ;
            }
            else
            {
                var confirmarMsj = MessageBox.Show("Seguro quiere agregar un nuevo destinatario?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmarMsj == DialogResult.Yes)
                {
                    AltaCtaBancaria altaCta = new AltaCtaBancaria(this);
                    altaCta.Show();
                    this.Hide();
                }

            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            Cliente titular = (Cliente)cmboxTitular.SelectedItem;
            Cuenta_Bancaria cuentaOrigen = (Cuenta_Bancaria)cmboxCuentaOrigen.SelectedItem;
            Cuenta_Bancaria cuentaDestino = (Cuenta_Bancaria)cmboxCuentaDestino.SelectedItem;

            var confir = MessageBox.Show($"Seguro desea realizar la siguiente transferencia?\n\nCuenta origen: {cuentaOrigen.NroCuenta}\nTitular: {titular.Nombre} {titular.Apellido}\nDNI: {titular.DNI}\n\n" +
               $"Cuenta destino: {cuentaDestino.NroCuenta}\nTitular:{cuentaDestino.Cliente.Nombre} {cuentaDestino.Cliente.Apellido}\nDNI: {cuentaDestino.Cliente.DNI}\nImporte: {txtImporte.Text}", "CONFIRMAR",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confir == DialogResult.OK)
            {
                principal.RealizarTransferencia(cuentaOrigen, decimal.Parse(txtImporte.Text), cuentaDestino);

                MessageBox.Show($"La transferencia fue realizada con exito.\n\nEl saldo actual de la cuenta: {cuentaOrigen.NroCuenta} es de: ${cuentaOrigen.Saldo}");

            }
            else
            {
            }
        }

        private void cmboxCuentaDestino_Validating(object sender, CancelEventArgs e)
        {
            if (cmboxCuentaDestino.SelectedItem == cmboxCuentaOrigen.SelectedItem)
            {
                MessageBox.Show("La cuenta de destino es igual a la cuenta de origen.\nPor favor corriga los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmboxCuentaDestino.SelectedIndex = -1; // hace que no este ningun elemento seleccionado
                errorProviderCtaDestino.SetError(cmboxCuentaDestino, "La cuenta de destino es igual a l;a cuenta de origen.");

            }
            else
            {
                errorProviderCtaDestino.SetError(cmboxCuentaDestino, "");
                btnExtraer.Enabled = true;

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
