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

namespace Front.Tarjetas_de_Credito
{
    public partial class Resumen : Form
    {
        public Resumen()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void Resumen_Load(object sender, EventArgs e)
        {
            cmboxTitular.Items.AddRange(principal.ObtenerClientesActivos().ToArray());

        }

        private void dgvResumenTarjeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmboxTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmboxTitular.SelectedItem;

            var tarjetasFiltradas = principal.TarjetasDeUnCliente(cliente);
            cmboxNroTarjeta.DataSource = null;
            cmboxNroTarjeta.DataSource = tarjetasFiltradas;
            cmboxNroTarjeta.DisplayMember = "NroTarjeta";
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Tarjeta_Credito tarjeta = (Tarjeta_Credito)cmboxNroTarjeta.SelectedItem;

            var resumenTarjeta = principal.ResumenTarjeta(tarjeta.ID);

            dgvResumenTarjeta.DataSource = null;
            dgvResumenTarjeta.DataSource = resumenTarjeta;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
