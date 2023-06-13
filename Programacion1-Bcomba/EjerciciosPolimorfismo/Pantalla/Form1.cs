using LibreriaClases;
using LibreriaClases.Ejercicio1;
using LibreriaClases.Ejercicio2;
using LibreriaClases.Ejercicio3;

namespace Pantalla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Animal> animales = new List<Animal>();
        private List<IVehiculo> vehiculos = new List<IVehiculo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxAnimal.Items.Add("Vaca");
            comboBoxAnimal.Items.Add("Gato");
            comboBoxAnimal.Items.Add("Perro");

            cmbVehiculo.Items.Add("Bicicleta");
            cmbVehiculo.Items.Add("Automovil");

            cmbTipofig.Items.Add("Cuadrado");
            cmbTipofig.Items.Add("Circulo");
            cmbTipofig.Items.Add("Rectangulo");


        }

        private void comboBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreAnimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptarAnimales_Click(object sender, EventArgs e)
        {
            if (comboBoxAnimal.SelectedIndex == 0)
            {
                Vaca miVaca = new Vaca();
                miVaca.Name = txtNombreAnimal.Text;
                animales.Add(miVaca);
            }
            if (comboBoxAnimal.SelectedIndex == 1)
            {
                Gato miGato = new Gato();
                miGato.Name = txtNombreAnimal.Text;
                animales.Add(miGato);
            }
            if (comboBoxAnimal.SelectedIndex == 2)
            {
                Perro miPerro = new Perro();
                miPerro.Name = txtNombreAnimal.Text;
                animales.Add(miPerro);
            }
            txtNombreAnimal.Text = "";
            comboBoxAnimal.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Animal ani in animales)
            {
                string listaString = ani.nombreSonido();
                MessageBox.Show(listaString);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            if (cmbVehiculo.SelectedIndex == 0)
            {
                Bicicleta bicicleta = new Bicicleta();
                bicicleta.Velocidad = int.Parse(txtveloIni.Text);
                vehiculos.Add(bicicleta);
            }
            else
            {
                Auto auto = new Auto();
                auto.Velocidad = int.Parse(txtveloIni.Text);
                vehiculos.Add(auto);
            }
            foreach (IVehiculo vehi in vehiculos)
            {
                txtVelocidadFin.Text = vehi.VelocidadFinal();
                lblVeloFin.Text = vehi.Acelerar();

            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtVelocidadIni_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVeloFin_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cmbTipofig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipofig.SelectedIndex == 0)
            {
                lblDatoFig1.Text = "Lado";
            }
            if (cmbTipofig.SelectedIndex == 1)
            {
                lblDatoFig1.Text = "Radio";
            }
            if (cmbTipofig.SelectedIndex == 2)
            {
                lblDatoFig1.Text = "Base";
                lblDatoFig2.Text = "Altura";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbTipofig.SelectedIndex == 0)
            {
                Cuadrado cuadrado = new Cuadrado();
                cuadrado.Lado = double.Parse(lblDatoFig1.Text);
                MessageBox.Show("El area es: " + cuadrado.Area());
            }
            if (cmbTipofig.SelectedIndex == 1)
            {
                Circulo circulo = new Circulo();
                circulo.Radio = double.Parse(lblDatoFig1.Text);
                MessageBox.Show("El area es: " + circulo.Area());
            }
            if (cmbTipofig.SelectedIndex == 2)
            {
                Rectangulo rectangulo = new Rectangulo();
                rectangulo.Base = double.Parse(lblDatoFig1.Text);
                rectangulo.Altura = double.Parse(lblDatoFig2.Text);
                MessageBox.Show("El area es: " + rectangulo.Area());
                
            }
        }
    }
}