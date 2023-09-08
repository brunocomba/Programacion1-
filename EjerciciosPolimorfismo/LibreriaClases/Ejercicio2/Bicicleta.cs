using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Ejercicio2
{
    public class Bicicleta : IVehiculo
    {
        public int Velocidad {get ; set;}

        int VelocidadNueva;
        public string Acelerar()
        {
            VelocidadNueva = Velocidad +10;
            return "La bicileta acelero. Velocidad anterior: " + Velocidad + "km/h " + "Velocidad actual: " + VelocidadNueva + "km/h";
        }
        public string VelocidadFinal()
        {
            return "Velocidad = " +( VelocidadNueva = Velocidad + 10); 
        }

    }
}
