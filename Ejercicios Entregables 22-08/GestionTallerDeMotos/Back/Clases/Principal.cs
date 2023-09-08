using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Principal
    {
        public static List<Deportiva> listaMotosDeportivas;

        public static List<Utilitaria> listaMotosUtilitarias;


        //--------------------------------------------- MOTOS DEPORTIVAS
        public static List<Deportiva> ObtenerMotosDepor()
        {
            if (listaMotosDeportivas == null)
            {
                listaMotosDeportivas = new List<Deportiva>();

                Deportiva motoDeporBase = new Deportiva(Deportiva.GenerateID(), "HONDA", "CBR", 600);

                listaMotosDeportivas.Add(motoDeporBase);

                Deportiva motoDeporBase2 = new Deportiva(Deportiva.GenerateID(), "BMW", "GS", 1200);

                listaMotosDeportivas.Add(motoDeporBase2);

                Deportiva motoDeporBase3 = new Deportiva(Deportiva.GenerateID(), "YAMAHA", "R1", 1000);

                listaMotosDeportivas.Add(motoDeporBase3);

            }
            return listaMotosDeportivas;


        }
        public void AltaMotoDepor(string marca, string modelo, int cilindrada)
        {
            Deportiva motoDepor = new Deportiva(Deportiva.GenerateID(), marca, modelo, cilindrada);
            listaMotosDeportivas.Add(motoDepor);
        }

        public void BajaMotoDepor(Deportiva motoDeporAEliminar)
        {
            listaMotosDeportivas.Remove(motoDeporAEliminar);
        }

        public void ModificarMotoDepor(Deportiva motoMod, string marca, string modelo, int cilindrada)
        {
            motoMod.Marca = marca;
            motoMod.Modelo = modelo;
            motoMod.Cilindrada = cilindrada;
            
        }
    







        //--------------------------------------------- MOTOS UTILITARIAS    
        public static List<Utilitaria> ObtenerMotosUtilitarias()
        {
            if (listaMotosUtilitarias == null)
            {
                listaMotosUtilitarias = new List<Utilitaria>();

                Utilitaria motoUtilitariaBase = new Utilitaria(Utilitaria.GenerateID(), "HONDA", "WAVE", "Trabajo");

                listaMotosUtilitarias.Add(motoUtilitariaBase);

                Utilitaria motoUtilitariaBase2 = new Utilitaria(Utilitaria.GenerateID(), "HONDA", "BIZ", "Delivery");

                listaMotosUtilitarias.Add(motoUtilitariaBase2);

                Utilitaria motoUtilitariaBase3 = new Utilitaria(Utilitaria.GenerateID(), "CORVEN", "ENERGY", "Trabajo");

                listaMotosUtilitarias.Add(motoUtilitariaBase3);

            }
            return listaMotosUtilitarias;

        }
        public void AltaMotoUtilitaria(string marca, string modelo, string uso)
        {
            Utilitaria motoUtilitaria = new Utilitaria(Utilitaria.GenerateID(), marca, modelo, uso);
            listaMotosUtilitarias.Add(motoUtilitaria);
        }

        public void BajaMotoUtilitaria(Utilitaria motoUtilitariaAEliminar)
        {
            listaMotosUtilitarias.Remove(motoUtilitariaAEliminar);
        }

        public void ModificarMotoUtilitaria(Utilitaria motoMod, string marca, string modelo, string uso)
        {
            motoMod.Marca = marca;
            motoMod.Modelo = modelo;
            motoMod.Uso = uso;

        }
    }
}
