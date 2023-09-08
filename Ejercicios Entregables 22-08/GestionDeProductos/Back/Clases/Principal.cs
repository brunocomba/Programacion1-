using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Principal
    {
        public static List<Smartphone> listaSmartphones;

        public static List<Televisor> listaTelevisores;

        // -------------------------------------- SMARTPHONES
        public static List<Smartphone> ObtenerSmartphones()
        {
            if (listaSmartphones == null)
            {
                listaSmartphones = new List<Smartphone>();

                Smartphone smartphoneBase = new Smartphone();
                smartphoneBase.Id = Smartphone.GenerateID();
                smartphoneBase.Marca = "SAMSUNG";
                smartphoneBase.Modelo = "A52";
                smartphoneBase.Precio = 150000;
                smartphoneBase.GbAlmacenamiento = 124;

                listaSmartphones.Add(smartphoneBase);

                Smartphone smartphoneBase2 = new Smartphone();
                smartphoneBase2.Id = Smartphone.GenerateID();
                smartphoneBase2.Marca = "SAMSUNG";
                smartphoneBase2.Modelo = "S23";
                smartphoneBase2.Precio = 570000;
                smartphoneBase2.GbAlmacenamiento = 1000;

                listaSmartphones.Add(smartphoneBase2);


                Smartphone smartphoneBase3 = new Smartphone();
                smartphoneBase3.Id = Smartphone.GenerateID();
                smartphoneBase3.Marca = "APPLE";
                smartphoneBase3.Modelo = "13 PRO";
                smartphoneBase3.Precio = 487000;
                smartphoneBase3.GbAlmacenamiento = 258;

                listaSmartphones.Add(smartphoneBase3);

            }
            return listaSmartphones;
        }

        public void AltaSmartphone(string marca, string modelo, int precio, int gb)
        {
            Smartphone smartphone = new Smartphone();
            smartphone.Id = Smartphone.GenerateID();
            smartphone.Marca = marca;
            smartphone.Modelo = modelo;
            smartphone.Precio = precio;
            smartphone.GbAlmacenamiento = gb;

            listaSmartphones.Add(smartphone);
        }

        public void BajaSmartphone(Smartphone smartphoneAEliminar)
        {
            listaSmartphones.Remove(smartphoneAEliminar);
        }

        public void ModificarSmartphone(Smartphone smartphoneMod, string marca, string modelo, int precio, int gb)
        {
            smartphoneMod.Marca = marca;
            smartphoneMod.Modelo = modelo;
            smartphoneMod.Precio = precio;
            smartphoneMod.GbAlmacenamiento = gb;

        }



        //-------------------------------------------------- TELEVISORES.
        public static List<Televisor> ObtenerTelevisores()
        {
            if (listaTelevisores == null)
            {
                listaTelevisores = new List<Televisor>();

                Televisor teleBase = new Televisor();
                teleBase.Id = Televisor.GenerateID();
                teleBase.Marca = "SAMSUNG";
                teleBase.Modelo = "G40";
                teleBase.Precio = 230000;
                teleBase.Pulgadas = 56;

                listaTelevisores.Add(teleBase);

                Televisor teleBase2 = new Televisor();
                teleBase2.Id = Televisor.GenerateID();
                teleBase2.Marca = "LG";
                teleBase2.Modelo = "HQR77";
                teleBase2.Precio = 198000;
                teleBase2.Pulgadas = 48;

                listaTelevisores.Add(teleBase2);


                Televisor teleBase3 = new Televisor();
                teleBase3.Id = Televisor.GenerateID();
                teleBase3.Marca = "LG";
                teleBase3.Modelo = "MQK10";
                teleBase3.Precio = 340000;
                teleBase3.Pulgadas = 69;

                listaTelevisores.Add(teleBase3);

            }
            return listaTelevisores;
        }

        public void AltaTele(string marca, string modelo, int precio, int pulgadas)
        {
            Televisor tele = new Televisor();
            tele.Id = Televisor.GenerateID();
            tele.Marca = marca;
            tele.Modelo = modelo;
            tele.Precio = precio;
            tele.Pulgadas = pulgadas; 

            listaTelevisores.Add(tele);
        }

        public void BajaTele(Televisor teleAEliminar)
        {
            listaTelevisores.Remove(teleAEliminar);
        }

        public void ModificarTele(Televisor teleMod, string marca, string modelo, int precio, int pulgadas)
        {
            teleMod.Marca = marca;
            teleMod.Modelo = modelo;
            teleMod.Precio = precio;
            teleMod.Pulgadas = pulgadas;

        }
    }

}
