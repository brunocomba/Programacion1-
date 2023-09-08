using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Televisor : ProductoElectronico
    {
        public int Pulgadas { get; set; }

        public override double CalcularImpuesto()
        {
            return Precio * 0.21;
        }

        public override double CalcularTotal()
        {
            return Precio + CalcularImpuesto();
        }

        private static int lastID = 0;

        public static int GenerateID()
        {
            lastID++;
            return lastID;
        }
    }
}
