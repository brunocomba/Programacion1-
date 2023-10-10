using Back.Clases;
using Front.Cuentas_Bancarias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Back.Clases.Cuenta_Bancaria;

namespace Front
{
    public partial class AltaCtaBancaria : Form
    {
        Form formPrevio;
        public AltaCtaBancaria(Form form)
        {
            InitializeComponent();
            formPrevio = form;
        }
        Principal principal = new Principal();
        private void AltaCtaBancaria_Load(object sender, EventArgs e)
        {
            //  MOSTRAR UN MENSAJE AL PASAR EL MOUSE POR ARRIBA DEL BOTON.
            toolTip1.SetToolTip(btnAgregarNuevoCliente, "Agregar un nuevo cliente.");


            cmboxCliente.Items.AddRange(principal.ObtenerClientesActivos().ToArray());

            // agregar los valores de la enumeracion de tipo de cuenta al combobox
            foreach (TipoDeCuenta tipo in Enum.GetValues(typeof(TipoDeCuenta)))
            {
                cmboxTipo.Items.Add(tipo.ToString());
            }

            //cmboxTipo.DataSource = Enum.GetValues(typeof(TipoDeCuenta));

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var confir = MessageBox.Show($"Seguro desea crear esta nueva Cuenta Bancaria?\nCliente: {cmboxCliente.SelectedItem}\nSaldo: {txtSaldo.Text}\nTipo: {cmboxTipo.SelectedItem}", "NUEVA CUENTA BANCARIA",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confir == DialogResult.OK)
            {
                principal.CrearCuentaBancaria((Cliente)cmboxCliente.SelectedItem, decimal.Parse(txtSaldo.Text),
                    (TipoDeCuenta)Enum.Parse(typeof(TipoDeCuenta), cmboxTipo.SelectedItem.ToString()));
                MessageBox.Show($"La cuenta bancaria numero al cliente {cmboxCliente.Text} se creo con exito ");
            }
            else
            {


            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPrevio.Show();
            this.Hide();
        }

        private void btnAgregarNuevoCliente_Click(object sender, EventArgs e)
        {
            AltaCliente altacliente = new AltaCliente(this);
            altacliente.Show();
            this.Hide();
        }
    }
}
