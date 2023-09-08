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
    public partial class ModificarUtilitario : Form
    {
        public ModificarUtilitario()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        ListaUtilitarias listaUtilitarias = new ListaUtilitarias();

        private Utilitaria motoQueEdito;
        public void RellenarInfo(Utilitaria motoUtilitaria)
        {
            motoQueEdito = motoUtilitaria;
            txtMarca.Text = motoQueEdito.Marca;
            txtModelo.Text = motoQueEdito.Modelo;
            txtUso.Text = motoQueEdito.Uso;

        }

        private void ModificarUtilitario_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var SIoNO = MessageBox.Show($"Seguro desea realizar esta modificacion?\n {motoQueEdito.Marca} por {txtMarca.Text}\n" +
               $"{motoQueEdito.Modelo} por {txtModelo.Text}\n {motoQueEdito.Uso} por {txtUso.Text}", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (SIoNO == DialogResult.OK)
            {
                principal.ModificarMotoUtilitaria(motoQueEdito, txtMarca.Text, txtModelo.Text, txtUso.Text);
                MessageBox.Show("Cliente modificado con exito!");
                listaUtilitarias.Show();
                this.Hide();
            }
            else
            {
                listaUtilitarias.Show();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            listaUtilitarias.Show();
            this.Hide();
        }
    }
}
