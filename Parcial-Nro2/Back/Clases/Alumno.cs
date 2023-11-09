using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Alumno
    {
        public int ID { get; set; }
        public long DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
