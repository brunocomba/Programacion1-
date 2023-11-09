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
    public partial class ModificarAlumno : Form
    {
        public ModificarAlumno()
        {
            InitializeComponent();
        }


        private Alumno alumnoQueEdito;

        // mostar datos del alumno elegido en la grilla
        public void ModificaCliente(Alumno cliente)
        {
            alumnoQueEdito = cliente;
            txtNombre.Text = alumnoQueEdito.Nombre;
            txtApellido.Text = alumnoQueEdito.Apellido;
            txtDNI.Text = alumnoQueEdito.DNI.ToString();
            dtpFecha.Value = alumnoQueEdito.fechaNacimiento;

        }
        Principal principal = new Principal();
        private void ModificarAlumno_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaAlumnos listaAlumnos = new ListaAlumnos();
            listaAlumnos.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;
            principal.ModificarAlumno(alumnoQueEdito, txtNombre.Text, txtApellido.Text, long.Parse(txtDNI.Text), fecha);
            MessageBox.Show($"El alumno {txtNombre.Text} {txtApellido.Text} fue modificado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
