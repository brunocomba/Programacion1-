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
    public partial class AltaLibro : Form
    {
        Principal principal = new Principal();
        public AltaLibro()
        {
            InitializeComponent();
        }

        

       
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            principal.AltaLibroFisico(txtISBN.Text, txtTItulo.Text, txtAutor.Text,
                decimal.Parse(txtPrecio.Text), int.Parse(txtNroPaginas.Text), decimal.Parse(txtPeso.Text));
            MessageBox.Show("Libro Fisico agregado con exito");

            txtISBN.Text = "";
            txtTItulo.Text = "";
            txtAutor.Text = "";
            txtPrecio.Text = "";
            txtNroPaginas.Text = "";
            txtPeso.Text = "";

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.MostrarListaLibrosFisicos();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void AltaLibro_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.MostrarListaLibrosFisicos();

           
           
        }
    }
}
