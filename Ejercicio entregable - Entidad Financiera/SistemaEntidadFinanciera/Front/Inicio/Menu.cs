using Front.Clientes;
using Front.Cuentas_Bancarias;
using Front.Tarjetas_de_Credito;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.INICIO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // si no esta visible,  lo va a mostrar
            if (!panelClientes.Visible)
            {
                panelClientes.Visible = true;
            }
            else // si lo esta mostrando, lo va a ocultar
            {
                panelClientes.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panelCtaBancaria.Visible)
            {
                panelCtaBancaria.Visible = true;
            }
            else
            {
                panelCtaBancaria.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panelTarjetaCredit.Visible)
            {
                panelTarjetaCredit.Visible = true;
            }
            else
            {
                panelTarjetaCredit.Visible = false;
            }

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AltaCliente altaCliente = new AltaCliente(this);
            altaCliente.Show();
            this.Hide();
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            ListadoClientes listadoClientes = new ListadoClientes();
            listadoClientes.Show();
            this.Hide();
        }

        private void btnAltaTarjeta_Click(object sender, EventArgs e)
        {
            AltaTarjetaCredito altaTarjetaCredito = new AltaTarjetaCredito(this);
            altaTarjetaCredito.Show();
            this.Hide();
        }

        private void btnListaTarjetas_Click(object sender, EventArgs e)
        {
            ListaTarjetaCredito listaTarjetaCredito = new ListaTarjetaCredito();
            listaTarjetaCredito.Show();
            this.Hide();
        }

        private void btnAddCta_Click(object sender, EventArgs e)
        {
            AltaCtaBancaria altaCtaBancaria = new AltaCtaBancaria(this);
            altaCtaBancaria.Show();
            this.Hide();
        }

        private void btnListaCtas_Click(object sender, EventArgs e)
        {
            ListaCtaBancaria lista = new ListaCtaBancaria();
            lista.Show();
            this.Hide();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito();
            deposito.Show();
            this.Hide();
        }
    }
}
