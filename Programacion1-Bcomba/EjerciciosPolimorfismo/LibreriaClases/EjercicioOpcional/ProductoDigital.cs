using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.EjercicioOpcional
{
    public class ProductoDigital : Producto
    {
        public  int Tamanio { get; set; }

        public ProductoDigital(string nombre, decimal precio, int tamanio) : base(nombre, precio)
        {
            Tamanio = tamanio;  
        }

        public override decimal CalcularImpuesto()
        {
            return 0.5m * Precio;
        }

        public override decimal CalcularTotal()
        {
            return Precio + CalcularImpuesto();
        }
    }
}
