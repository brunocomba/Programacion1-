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
    public partial class ListaAlumnos : Form
    {
        public ListaAlumnos()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        private void ListaAlumnos_Load(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = principal.GetAlumnos();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarAlumno modAlumno = new ModificarAlumno();

            // convertir a objeto cliente la fila seleccionada en la grilla
            Alumno alumnoElegido = (Alumno)dgvAlumnos.CurrentRow.DataBoundItem;

            // pasarle el cliente elegido en bla grilla al metodo del formulario de modificacion para que lo utilice
            modAlumno.ModificaCliente(alumnoElegido);
            modAlumno.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Alumno alumnoElegido = (Alumno)dgvAlumnos.CurrentRow.DataBoundItem;
            var confirmacion = MessageBox.Show($"Seguro que desea eliminar el alumno  {alumnoElegido.Nombre} con el DNI {alumnoElegido.DNI}", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.OK)
            {
                principal.EliminarAlumno(alumnoElegido);
            }
        }
    }
}
