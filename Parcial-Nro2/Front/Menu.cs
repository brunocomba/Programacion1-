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

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aLUMNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aLTAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaAlumno altaAlumno = new AltaAlumno();
            altaAlumno.Show();
            this.Hide();
        }

        private void aLTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProfesor altaProfesor = new AltaProfesor();
            altaProfesor.Show();
            this.Hide();
        }

        private void aLTAToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AltaCurso altaCurso = new AltaCurso();
            altaCurso.Show();
            this.Hide();
        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAlumnos listaAlumnos = new ListaAlumnos();
            listaAlumnos.Show();
            this.Hide();
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAlumnos listaAlumnos = new ListaAlumnos();
            listaAlumnos.Show();
            this.Hide();
        }
    }
}
