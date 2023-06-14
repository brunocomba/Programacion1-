using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Auto : IVehiculo
    {
        public int Velocidad { get; set; }
        
        int VelocidadNueva;
        public string Acelerar()
        {
            VelocidadNueva = Velocidad +70;
            return "El auto acelero. Velocidad anterior: " + Velocidad + "km/h "  + "Velocidad actual: " + VelocidadNueva + "km/h";
           
        }
        public string VelocidadFinal()
        {
            return "Velocidad = " + (VelocidadNueva = Velocidad +70);
        }

        
        
    }
}
