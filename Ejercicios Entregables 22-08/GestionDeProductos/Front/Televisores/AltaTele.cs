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
    public partial class AltaTele : Form
    {
        public AltaTele()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            var respuesta = MessageBox.Show($"Seguro desea agregar este nuevo Televisor al registro?\n \n Marca: {txtMarca.Text}\n" +
               $" Modelo: {txtModelo.Text}\n  Pulgadas de tamaño: {txtPulgadas.Text}\n Precio: {txtPrecio.Text}", "COFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                principal.AltaTele(txtMarca.Text, txtModelo.Text, int.Parse(txtPrecio.Text), int.Parse(txtPulgadas.Text));
                MessageBox.Show($"Televisor {txtMarca.Text} {txtModelo.Text} agregado con exito al registro.");
                txtMarca.Clear();
                txtModelo.Clear();
                txtPulgadas.Clear();
                txtPrecio.Clear();
            }
            else
            {
                txtMarca.Clear();
                txtModelo.Clear();
                txtPulgadas.Clear();
                txtPrecio.Clear();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaTele listaTele = new ListaTele();
            listaTele.Show();
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

        private void txtPulgadas_KeyPress(object sender, KeyPressEventArgs e)
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

