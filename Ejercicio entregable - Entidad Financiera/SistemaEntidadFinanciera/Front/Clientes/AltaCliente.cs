using Back.Clases;
using Front.Clientes;
using System;

namespace Front
{
    public partial class AltaCliente : Form
    {
        private Form formPrevio;

        // Pedir como parametro el formulario al instanciar este form (AltaCliente)
        public AltaCliente( Form form)
        {
            InitializeComponent();
            formPrevio = form;
        }
        Principal principal = new Principal();


        private void btnCrear_Click(object sender, EventArgs e)
        {
            var confir = MessageBox.Show($"Seguro desea crear este nuevo cliente?\n\nNombre: {txtNombre.Text}\nApellido: {txtApellido.Text}\nDNI: {txtDNI.Text}", "NUEVO CLIENTE",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confir == DialogResult.OK)
            {
                principal.AgregarCliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text));
                MessageBox.Show($"El cliente {txtNombre.Text} {txtApellido.Text} se creo con exito! ");
                formPrevio.Show();
                this.Hide();
            }
            else
            {
                txtNombre.Clear(); txtApellido.Clear(); txtDNI.Clear();
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPrevio.Show();
            this.Hide();    
        }
    }
}
