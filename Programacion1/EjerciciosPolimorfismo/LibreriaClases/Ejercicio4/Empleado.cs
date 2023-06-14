using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.EJercicio4
{
    public class Empleado
    {
        public string nombre { get; set; }
        public decimal salarioBase { get; set; }
        public virtual decimal CalcularSalario()
        {
            return salarioBase;
        }
    }

}
