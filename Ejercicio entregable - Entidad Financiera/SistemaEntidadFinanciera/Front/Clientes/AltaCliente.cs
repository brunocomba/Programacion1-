using Back.Clases;
using Front.Clientes;
using System;

namespace Front
{
    public partial class AltaCliente : Form
    {
        private Form formPrevio;

        // Pedir como parametro el formulario al instanciar este form (AltaCliente)
        public AltaCliente(Form form)
        {
            InitializeComponent();
            formPrevio = form;
        }
        Principal principal = new Principal();


        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDNI.Text;
            }

            catch (Exception dniIncompleto)
            {
                MessageBox.Show("Error: " + dniIncompleto.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {
                string dni = txtDNI.Text;

            }
            catch (Exception soloNros)
            {
                MessageBox.Show("Error: " + soloNros.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                principal.AgregarCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text);
                MessageBox.Show($"El cliente {txtNombre.Text} {txtApellido.Text} se creo con exito! ");
                formPrevio.Show();
                this.Hide();

            }
            catch (Exception camposIncompletos)
            {
                // Manejar la excepción de campos incompletos
                MessageBox.Show("Error: " + camposIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPrevio.Show();
            this.Hide();
        }
    }
}
