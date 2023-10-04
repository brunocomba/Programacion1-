using Back.Clases;
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
using static Back.Clases.Cuenta_Bancaria;
using static Back.Clases.Tarjeta_Credito;

namespace Front
{
    public partial class AltaTarjetaCredito : Form
    {
        Form formPrevio;
        public AltaTarjetaCredito(Form form)
        {
            InitializeComponent();
            formPrevio = form;
        }

        Principal principal = new Principal();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AltaTarjetaCredito_Load(object sender, EventArgs e)
        {
            //  MOSTRAR UN MENSAJE AL PASAR EL MOUSE POR ARRIBA DEL BOTON.
            toolTip1.SetToolTip(btnAgregarNuevoCliente, "Agregar un nuevo cliente.");


            cmboxCliente.Items.AddRange(principal.ObtenerClientesActivos().ToArray());

            // agregar los valores de la enumeracion de tipo de cuenta al combobox
            foreach (EstadoTarjetaCredito tipo in Enum.GetValues(typeof(EstadoTarjetaCredito)))
            {
                cmboxEstado.Items.Add(tipo.ToString());
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var confir = MessageBox.Show($"Seguro desea emitir esta nueva Tarjeta de Credito?\nCliente: {cmboxCliente.SelectedItem}\nNro de cuenta: {txtNroTarjeta.Text}\nLimite de Credito: {txtLimiteCredito.Text}" +
                $"\\\nEstado: {cmboxEstado.SelectedItem}", "NUEVA TARJETA DE CREDITO",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confir == DialogResult.OK)
            {
                principal.EmitirTarjetaCredito((Cliente)cmboxCliente.SelectedItem, decimal.Parse(txtNroTarjeta.Text), decimal.Parse(txtLimiteCredito.Text),
                    (EstadoTarjetaCredito)Enum.Parse(typeof(EstadoTarjetaCredito), cmboxEstado.SelectedItem.ToString()));
                MessageBox.Show($"La Tajeta de Credito con Nro de Tarjeta: {txtNroTarjeta.Text} se creo con exito! ");
                cmboxCliente = null;
                cmboxEstado = null;
                txtLimiteCredito.Clear();
                txtNroTarjeta.Clear();
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
            AltaCliente altaclietne = new AltaCliente(this);
            altaclietne.Show();
            this.Hide();
        }
    }
}
