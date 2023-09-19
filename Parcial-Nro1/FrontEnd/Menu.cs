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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void libroFisicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void libroFisicoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AltaLibro altaLibro = new AltaLibro();
            altaLibro.Show();
            this.Hide();
        }

        private void libroDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaLibroDigital altaLibroDigital = new AltaLibroDigital();
            altaLibroDigital.Show();
            this.Hide();
        }
    }
}
