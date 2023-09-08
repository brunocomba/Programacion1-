using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public  class Animal
    {
        public string Name { get; set; }

        public virtual string sonidoAnimal()
        {
            return "Sondio generico de animales";

        }
        public string devolverNombre()
        {
            return Name;
        }
        public string nombreSonido()
        {
            return "Hola mi nombre es: " + devolverNombre() + " y hago el sonido: " + sonidoAnimal();
        }

    }
}