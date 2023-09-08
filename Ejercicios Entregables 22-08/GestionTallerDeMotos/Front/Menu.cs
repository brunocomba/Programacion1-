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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDeportivas lista = new ListaDeportivas();
            lista.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaUtilitarias listaUtilitarias = new ListaUtilitarias();
            listaUtilitarias.Show();
            this.Hide();
        }
    }
}
