using Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        List<Cliente> ListaClientes = new List<Cliente>();
        List<Libro> ListaLibros = new List<Libro>();
        List<Prestamo> ListaPrestamos = new List<Prestamo>();



        public void AgregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }
        public void AgregarLibro(Libro libro)
        {
            ListaLibros.Add(libro);
        }


    }
}
