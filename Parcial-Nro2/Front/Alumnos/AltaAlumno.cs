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
    public partial class AltaAlumno : Form
    {
        public AltaAlumno()
        {
            InitializeComponent();
        }


        Principal principal = new Principal();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;

            principal.AltaAlumno(txtNombre.Text, txtApellido.Text, long.Parse(txtDNI.Text), fecha);
            MessageBox.Show($"El alumno {txtNombre.Text} {txtApellido.Text} fue agregado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void AltaAlumno_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            dtpFecha.CustomFormat = "dd/MM/yyyy";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
