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

        private void btnSmartphones_Click(object sender, EventArgs e)
        {
            ListaSmartphones listaSmartphones = new ListaSmartphones();
            listaSmartphones.Show();
            this.Hide();
        }

        private void btnTelevisores_Click(object sender, EventArgs e)
        {
            ListaTele listaTele = new ListaTele();  
            listaTele.Show();   
            this.Hide();
        }
    }
}
