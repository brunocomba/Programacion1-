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
    public partial class AltaSmartphone : Form
    {
        public AltaSmartphone()
        {
            InitializeComponent();
        }

        private void AltaSmartphone_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            var respuesta = MessageBox.Show($"Seguro desea agregar este nuevo Smartphone al registro?\n \n Marca: {txtMarca.Text}\n" +
               $" Modelo: {txtModelo.Text}\n  GB Almacenamiento: {txtGB.Text}\n Precio: {txtPrecio.Text}", "COFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                principal.AltaSmartphone(txtMarca.Text, txtModelo.Text, int.Parse(txtPrecio.Text), int.Parse(txtGB.Text));
                MessageBox.Show($"Smartphone {txtMarca.Text} {txtModelo.Text} agregado con exito al registro.");
                txtMarca.Clear();
                txtModelo.Clear();
                txtGB.Clear();
                txtPrecio.Clear();
            }
            else
            {
                txtMarca.Clear();
                txtModelo.Clear();
                txtGB.Clear();
                txtPrecio.Clear();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaSmartphones listaSmartphones = new ListaSmartphones();
            listaSmartphones.Show();
            this.Hide();

        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96)
                || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir numeros, solo LETRAS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtGB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir letras, solo NUMEROS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir letras, solo NUMEROS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }
    }
}
