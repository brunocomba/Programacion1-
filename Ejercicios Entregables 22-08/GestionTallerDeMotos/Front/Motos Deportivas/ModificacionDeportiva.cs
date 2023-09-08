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
    public partial class ModificacionDeportiva : Form
    {
        public ModificacionDeportiva()
        {
            InitializeComponent();
        }
        
        Principal principal = new Principal();
        ListaDeportivas listaDeportivas = new ListaDeportivas();

        private Deportiva motoQueEdito;
        public void RellenarInfo(Deportiva motoDepor)
        {
            motoQueEdito = motoDepor;
            txtMarca.Text = motoQueEdito.Marca;
            txtModelo.Text = motoQueEdito.Modelo;
            txtCilindrada.Text = motoQueEdito.Cilindrada.ToString();

        }
        
        private void Modificacion_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            var SIoNO = MessageBox.Show($"Seguro desea realizar esta modificacion?\n {motoQueEdito.Marca} por {txtMarca.Text}\n" +
                $"{motoQueEdito.Modelo} por {txtModelo.Text}\n {motoQueEdito.Cilindrada} por {txtCilindrada.Text}", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (SIoNO == DialogResult.OK)
            {
                principal.ModificarMotoDepor(motoQueEdito, txtMarca.Text, txtModelo.Text, int.Parse(txtCilindrada.Text));
                MessageBox.Show("Cliente modificado con exito!");
                listaDeportivas.Show();
                this.Hide();
            }
            else
            {
                listaDeportivas.Show();
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

        private void txtCilindrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir letras, solo NUMEROS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            listaDeportivas.Show();
            this.Hide();

        }
    }
}
