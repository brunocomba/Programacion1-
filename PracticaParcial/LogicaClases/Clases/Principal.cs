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
        public void AltaCliente(int Id, int Dni, string Nombre, string Apellido)
        {
            Cliente nuevoCliente = new Cliente();

           // var contador = ListaClientes.Count() + 1; // id autonumierico
            nuevoCliente.id = Id;
            nuevoCliente.dni = Dni;
            nuevoCliente.nombre = Nombre;
            nuevoCliente.apellido = Apellido;

            AgregarCliente(nuevoCliente);
        }


        public static List<Cliente> ListaClientes;

        public static List<Cliente> ObtenerClientes()
        {
            if (ListaClientes == null)
            {
                ListaClientes = new List<Cliente>();

                Cliente clienteHarcor = new Cliente();
                clienteHarcor.id = 1;
                clienteHarcor.dni = 45414815;
                clienteHarcor.nombre = "Bruno";
                clienteHarcor.apellido = "Comba";

                ListaClientes.Add(clienteHarcor);

                Cliente clienteHarcor2 = new Cliente();
                clienteHarcor2.id = 2;
                clienteHarcor2.dni = 33987221;
                clienteHarcor2.nombre = "Martin";
                clienteHarcor2.apellido = "Palermo";

                ListaClientes.Add(clienteHarcor2);

                Cliente clienteHarcor3 = new Cliente();
                clienteHarcor3.id = 3;
                clienteHarcor3.dni = 22678993;
                clienteHarcor3.nombre = "Roman";
                clienteHarcor3.apellido = "Riquelme";

                ListaClientes.Add(clienteHarcor3);

            }
            return ListaClientes;
        }

        public void removeThisCliente(Cliente clienteABorrar)
        {
            ObtenerClientes().Remove(clienteABorrar);
        }  
        public void modificarCliente(Cliente nuevoCliente, int Id, int DNI, string Nombre, string Apellido)
        {
            nuevoCliente.id = Id;
            nuevoCliente.dni = DNI;
            nuevoCliente.nombre = Nombre;
            nuevoCliente.apellido= Apellido;   

        }
    }
}
