using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Utilitaria : Moto
    {
       
        public string Uso { get; set; }
        public Utilitaria(int id, string marca, string modelo, string uso) : base(id, marca, modelo)
        {
            Uso = uso;
        }

        public override string RealizarMantenimiento()
        {
            return $"Se esta realizando el mantemiento.\n Moto: {Marca + Modelo}\n Utilidad: {Uso}";
        }

        private static int lastID = 0;

        public static int GenerateID()
        {
            lastID++;
            return lastID;
        }
    }
}
