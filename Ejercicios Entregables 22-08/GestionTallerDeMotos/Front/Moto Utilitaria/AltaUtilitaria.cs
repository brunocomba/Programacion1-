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
    public partial class AltaUtilitaria : Form
    {
        public AltaUtilitaria()
        {
            InitializeComponent();
        }

        private void AltaUtilitaria_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            var respuesta = MessageBox.Show($"Seguro desea agregar esta nueva moto al registro?\n Moto: {txtMarca.Text + txtModelo.Text}\n" +
               $" Uso: {txtUso.Text}", "COFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                principal.AltaMotoUtilitaria(txtMarca.Text, txtModelo.Text, txtUso.Text);

                txtMarca.Clear();
                txtModelo.Clear();
                txtUso.Clear();
            }
            else
            {
                txtMarca.Clear();
                txtModelo.Clear();
                txtUso.Clear();
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaUtilitarias listaUti = new ListaUtilitarias();
            listaUti.Show();
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

        private void txtUso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96)
                 || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir numeros, solo LETRAS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }
    }

}
