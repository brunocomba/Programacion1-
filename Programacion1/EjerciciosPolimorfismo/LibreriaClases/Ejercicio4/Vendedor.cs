using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.EJercicio4
{
    public class Vendedor : Empleado
    {
        public decimal comision { get; set; }

        public override decimal CalcularSalario()
        {
            return salarioBase + comision;
        }

    }
}
