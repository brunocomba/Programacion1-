using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Ejercicio3
{
    public class Rectangulo : FiguraGeometrica
    {
        public double Base {get;set;}   
        public double Altura {get;set;}

        public override double Area()
        {
            return Base * Altura;
        }
    }
}
