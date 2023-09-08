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
    public partial class ModificacionSmartphone : Form
    {
        public ModificacionSmartphone()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        ListaSmartphones listaSmartphones = new ListaSmartphones();

        private Smartphone celuQueEdito;
        public void RellenarInfo(Smartphone smartphone)
        {
            celuQueEdito = smartphone;
            txtMarca.Text = celuQueEdito.Marca;
            txtModelo.Text = celuQueEdito.Modelo;
            txtGB.Text = celuQueEdito.GbAlmacenamiento.ToString();
            txtPrecio.Text = celuQueEdito.Precio.ToString();

        }
        private void ModificacionSmartphone_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            listaSmartphones.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var SIoNO = MessageBox.Show($"Seguro desea realizar esta modificacion?\n {celuQueEdito.Marca} por {txtMarca.Text}\n" +
            $"{celuQueEdito.Modelo} por {txtModelo.Text}\n {celuQueEdito.GbAlmacenamiento} por {txtGB.Text}\n {celuQueEdito.Precio} por {txtPrecio.Text}", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (SIoNO == DialogResult.OK)
            {
                principal.ModificarSmartphone(celuQueEdito, txtMarca.Text, txtModelo.Text, int.Parse(txtPrecio.Text), int.Parse(txtGB.Text));
                MessageBox.Show("Smartphone modificado con exito!");
                listaSmartphones.Show();
                this.Hide();
            }
            else
            {
                listaSmartphones.Show();
                this.Hide();
            }
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
