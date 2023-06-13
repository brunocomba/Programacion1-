using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public abstract class FiguraGeometrica
    {
        public string Name { get; set; }
        public abstract double Area();
        
        public string DecimeQuienSos()
        {
            return "El area del " + Name + " es de:  " + Area();
        }

    }
}
