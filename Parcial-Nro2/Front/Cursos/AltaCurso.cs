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
    public partial class AltaCurso : Form
    {
        public AltaCurso()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        private void AltaCurso_Load(object sender, EventArgs e)
        {
            cmboxProfesores.Items.AddRange(principal.ObtenerProfesores().ToArray());

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Profesor profeSeleccionado = (Profesor)cmboxProfesores.SelectedItem;
            principal.AltaCurso(txtNombre.Text, txtDescripcion.Text, profeSeleccionado);
            MessageBox.Show($"El curso {txtNombre.Text} fue agregado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
