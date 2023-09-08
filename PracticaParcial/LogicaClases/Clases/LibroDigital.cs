
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class LibroDigital : Libro
    {
        public int tamanioArchivo { get; set; }
        public string formato { get; set; }

        public override string ObtenerInformacion()
        {
            return  $"Título: {titulo}\nAutor: {autor}\nAño de Publicación: {anioPublicacion}\nTamaño del Archivo: {tamanioArchivo} MB\nFormato: {formato}\nDisponible: {(disponible ? "Sí" : "No")}";
        }
    }
}
