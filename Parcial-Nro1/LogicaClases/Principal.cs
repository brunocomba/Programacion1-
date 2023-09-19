using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases
{
    public class Principal
    {
        public List<LibroDigital> ListaLibroDigital = new List<LibroDigital>();
        public List<LibroFisico> ListaLibroFisico = new List<LibroFisico>();

        public void AltaLibroFisico(string ISBN, string Titulo, string Autor, decimal Precio, int NroPaginas, decimal Peso)
        {
            LibroFisico libroFisico = new LibroFisico();
            libroFisico.isbn = ISBN;
            libroFisico.titulo = Titulo;
            libroFisico.autor = Autor;
            libroFisico.precio = Precio;
            libroFisico.nroPaginas = NroPaginas;
            libroFisico.peso = Peso;

            ListaLibroFisico.Add(libroFisico);
        }

        public void AltaLibroDigital(string ISBN, string Titulo, string Autor, decimal Precio, string Formato, decimal Tamanio)
        {
            LibroDigital libroDigital = new LibroDigital();
            libroDigital.isbn = ISBN;
            libroDigital.titulo = Titulo;
            libroDigital.autor = Autor;
            libroDigital.precio = Precio;
            libroDigital.formato = Formato;
            libroDigital.tamanio = Tamanio;

            ListaLibroDigital.Add(libroDigital);
        }

        public List<LibroFisico> MostrarListaLibrosFisicos()
        {
            return ListaLibroFisico;
        }

        public List<LibroDigital> MostrarListaLibrosDigitales()
        {
            return ListaLibroDigital;
        }


    }
}
