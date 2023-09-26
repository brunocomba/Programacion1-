using Back.Clases;
using Front.INICIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Cuentas_Bancarias
{
    public partial class ListaCtaBancaria : Form
    {
        public ListaCtaBancaria()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        private void btnNuevaCtaBancaria_Click(object sender, EventArgs e)
        {
            AltaCtaBancaria altaCtaBancaria = new AltaCtaBancaria(this);
            altaCtaBancaria.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void ListaCtaBancaria_Load(object sender, EventArgs e)
        {
            //dgvCtasBancarias.DataSource = principal.ObtenerCuentasBancarias();

            dgvCtasBancarias.DataSource = principal.CuentasBancarias();
        }

        private void dgvCtasBancarias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }
    }
}
