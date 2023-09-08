﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Circulo : FiguraGeometrica
    {
        public double Radio { get ; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
            // Math es una libreria, el metodo pow sirve para elevar a la 2, en este caso Radio a la 2.

        }
    }
}
