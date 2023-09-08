using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.EJercicio4
{
    public class Gerente : Empleado
    {
        public decimal bono { get; set; }
        public override decimal CalcularSalario()
        {
            return salarioBase + bono;

        }
    }
}
