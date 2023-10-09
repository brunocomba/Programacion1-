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

namespace Front.Tarjetas_de_Credito
{
    public partial class ResumenCompras : Form
    {
        public ResumenCompras()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Tarjeta_Credito tarjeta = (Tarjeta_Credito)cmboxNroTarjeta.SelectedItem;

            var resumenTarjeta = principal.ResumenCompras(tarjeta);

            dgvResumenTarjeta.DataSource = null;
            dgvResumenTarjeta.DataSource = resumenTarjeta;
        }

        private void cmboxTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmboxTitular.SelectedItem;

            var tarjetasFiltradas = principal.TarjetasDeUnCliente(cliente);
            cmboxNroTarjeta.DataSource = null;
            cmboxNroTarjeta.DataSource = tarjetasFiltradas;
            cmboxNroTarjeta.DisplayMember = "NroTarjeta";
        }

        private void ResumenCompras_Load(object sender, EventArgs e)
        {
            cmboxTitular.Items.AddRange(principal.ObtenerClientesActivos().ToArray());

        }
    }
}
