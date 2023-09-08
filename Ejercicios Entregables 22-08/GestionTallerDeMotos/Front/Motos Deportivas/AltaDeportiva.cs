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
    public partial class AltaDeportiva : Form
    {
        public AltaDeportiva()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            var respuesta = MessageBox.Show($"Seguro desea agregar esta nueva moto al registro?\n Moto: {txtMarca.Text + txtModelo.Text}\n" +
               $" Cilindrada: {txtCilindrada.Text}", "COFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                principal.AltaMotoDepor(txtMarca.Text, txtModelo.Text, int.Parse(txtCilindrada.Text));

                txtMarca.Clear();
                txtModelo.Clear();
                txtCilindrada.Clear();
            }
            else
            {
                txtMarca.Clear();
                txtModelo.Clear();
                txtCilindrada.Clear();
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaDeportivas lista = new ListaDeportivas();
            lista.Show();
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

        private void txtCilindrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir letras, solo NUMEROS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }
    }
}
