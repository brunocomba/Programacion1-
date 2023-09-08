using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Deportiva : Moto
    {
        public int Cilindrada { get; set; }

        private static int lastID = 0;

        public static int GenerateID()
        {
            lastID++;
            return lastID;
        }
        public override string RealizarMantenimiento()
        {
            return $"Se esta realizando el mantenimiento.\n Moto: {Marca + Modelo}\n Cilindrada: {Cilindrada}";
        }

        public Deportiva(int id, string marca, string modelo, int cilindrada) : base(id, marca, modelo)
        {
            Cilindrada = cilindrada;
        }
    }
}
