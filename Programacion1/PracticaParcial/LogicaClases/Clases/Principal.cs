using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Principal
    {
        
        public List<Libro> ListaLibros = new List<Libro>();
        public List<Prestamo> ListaPrestamos = new List<Prestamo>();



        public void AgregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }
        public void AgregarLibro(Libro libro)
        {
            ListaLibros.Add(libro);
        }



        public static List<Cliente> ListaClientes;

        public static List<Cliente> ObtenerClientes()
        {
            if (ListaClientes == null)
            {
                ListaClientes = new List<Cliente>();

                Cliente cliente1 = new Cliente();
                cliente1.dni = 45414815;
                cliente1.nombre = "Bruno";
                cliente1.apellido = "Comba";

                ListaClientes.Add(cliente1);

                Cliente cliente2 = new Cliente();
                cliente2.dni = 32897543;
                cliente2.nombre = "Martin";
                cliente2.apellido = "Palermo";

                ListaClientes.Add (cliente2);

                Cliente cliente3 = new Cliente();
                cliente3.dni = 21654789;
                cliente3.nombre = "Roman";
                cliente3.apellido = "Riquelme";

                ListaClientes.Add(cliente3);

            }
            return ListaClientes;

        }

        public void removeThisCliente(Cliente clienteABorrar)
        {
            ObtenerClientes().Remove(clienteABorrar);
        }  

    }
}
