using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.EjercicioOpcional
{
    public class ProductoFisico : Producto
    {
        public decimal Peso { get; set; }

        public ProductoFisico(string nombre, decimal precio, decimal peso) : base(nombre, precio)
        {
            Peso = peso;
        }

        public override decimal CalcularImpuesto()
        {
            return Precio * 0.10m;
        }

        public override decimal CalcularTotal()
        {
            return Precio + CalcularImpuesto();
        }
    }
}
