using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Compra_Tarjeta
    {
        public int ID { get; set; }
        public Tarjeta_Credito Tarjeta { get; set; }
        public string Detalle { get; set; }
        public decimal Precio { get; set; }

    }
}
