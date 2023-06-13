using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Ejercicio3
{
    public class Cuadrado : FiguraGeometrica
    {
        public double Lado { get; set; }
        public override double Area()
        {
            return Lado * Lado;
        }
    }

}
