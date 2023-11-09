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
    public partial class AltaProfesor : Form
    {
        public AltaProfesor()
        {
            InitializeComponent();
        }


        Principal principal = new Principal();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            principal.AltaProfesor(txtNombre.Text, txtApellido.Text, txtEmail.Text, long.Parse(txtTel.Text));
            MessageBox.Show($"El profesor {txtNombre.Text} {txtApellido.Text} fue agregado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
