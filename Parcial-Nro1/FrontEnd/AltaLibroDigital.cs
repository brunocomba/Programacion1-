using LogicaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class AltaLibroDigital : Form
    {
        Principal principal = new Principal();
        public AltaLibroDigital()
        {
            InitializeComponent();
        }

        private void AltaLibroDigital_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.MostrarListaLibrosDigitales();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            principal.AltaLibroDigital(txtISBN.Text, txtTitulo.Text, txtAutor.Text, decimal.Parse(txtPrecio.Text),
                txtFormato.Text, decimal.Parse(txtTamanio.Text));
            MessageBox.Show("Libro Digital agregado con exito");
            
            txtISBN.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtPrecio.Text = "";
            txtFormato.Text = "";
            txtTamanio.Text = "";

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.MostrarListaLibrosDigitales();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();

        }
    }

   
}
