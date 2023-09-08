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
    public partial class ModificacionTele : Form
    {
        public ModificacionTele()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        ListaTele listaTele = new ListaTele();

        private Televisor teleQueEdito;
        public void RellenarInfo(Televisor tele)
        {
            teleQueEdito = tele;
            txtMarca.Text = teleQueEdito.Marca;
            txtModelo.Text = teleQueEdito.Modelo;
            txtPulgadas.Text = teleQueEdito.Pulgadas.ToString();
            txtPrecio.Text = teleQueEdito.Precio.ToString();

        }
        private void ModificacionTele_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var SIoNO = MessageBox.Show($"Seguro desea realizar esta modificacion?\n {teleQueEdito.Marca} por {txtMarca.Text}\n" +
           $"{teleQueEdito.Modelo} por {txtModelo.Text}\n {teleQueEdito.Pulgadas} por {txtPulgadas.Text}\n {teleQueEdito.Precio} por {txtPrecio.Text}", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (SIoNO == DialogResult.OK)
            {
                principal.ModificarTele(teleQueEdito, txtMarca.Text, txtModelo.Text, int.Parse(txtPrecio.Text), int.Parse(txtPulgadas.Text));
                MessageBox.Show("Smartphone modificado con exito!");
                listaTele.Show();
                this.Hide();
            }
            else
            {

                listaTele.Show();
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

        private void txtPulgadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir letras, solo NUMEROS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            listaTele.Show();
            this.Hide();
        }
    }
}
