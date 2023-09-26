using Back.ConeccionBD;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Data;
using static Back.Clases.Cliente;
using static Back.Clases.Cuenta_Bancaria;
using static Back.Clases.Tarjeta_Credito;

namespace Back.Clases
{
    public class Principal
    {
        AppDbContext context = new AppDbContext();

        // ---------------- LISTAS DECLARADAS A UTILIZAR;

        private List<Cliente> listaClientes = new List<Cliente>();

        private List<Cliente> clientesActivos = new List<Cliente>();

        private List<Cuenta_Bancaria> cuentasBancarias = new List<Cuenta_Bancaria>();

        private List<string> comprasConTarjeta = new List<string>();


        // ------------------------------------ CLIENTES ----------------------------------------------

        public void AgregarCliente(string nombre, string apellido, int dni) 
        {
            Cliente clienteNew = new Cliente();

            clienteNew.Nombre = nombre;
            clienteNew.Apellido = apellido;
            clienteNew.DNI = dni;
            clienteNew.Estado = EstadoCliente.Activo;

            context.Clientes.Add(clienteNew);
            context.SaveChanges();            
        }

        public void EliminarCliente(Cliente cliente)
        {
            if (cliente != null) 
            {
                cliente.Estado = EstadoCliente.Pausado;

                context.Clientes.Update(cliente);
                context.SaveChanges();
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            listaClientes = context.Clientes.ToList();

            return listaClientes;
        }

        public List<Cliente> ObtenerClientesActivos()
        {

            foreach (Cliente cliente in context.Clientes.ToList())
            {
                if (cliente.Estado.Equals(EstadoCliente.Activo))
                {
                    clientesActivos.Add(cliente);
                }
            }
            return clientesActivos;
        }

        // ------------------------------- CUENTAS BANCARIAS ----------------------------------------------

        public void CrearCuentaBancaria(Cliente cliente, decimal nroCuenta, decimal saldo, TipoDeCuenta tipo)
        {
            if (cliente != null && cliente.Estado != EstadoCliente.Pausado)
            {
                Cuenta_Bancaria newCtaBancaria = new Cuenta_Bancaria();
                
                newCtaBancaria.Cliente = cliente;
                newCtaBancaria.NroCuenta = nroCuenta;
                newCtaBancaria.Saldo = saldo;
                newCtaBancaria.Tipo = tipo;

                context.Cuentas_Bancarias.Add(newCtaBancaria);
                context.SaveChanges();
            }
        }

        // retorna lista completas de cuentas
        public List<Cuenta_Bancaria> listaCuentasBancarias()
        {
            cuentasBancarias = context.Cuentas_Bancarias.ToList();
            return cuentasBancarias;
        }

        // al pasarle un cliente, busca las cuentas que tengan dicho cliente y las agrrega a una lista nueva
        public List<Cuenta_Bancaria> CuentasDeUnCliente(Cliente clienteABuscar)
        {
            var cuentasFiltradas = listaCuentasBancarias().Where(cuenta => cuenta.Cliente.ID == clienteABuscar.ID).ToList();

            return cuentasFiltradas;
        }

        // todas las cuentas menos la de un cliente en particular
        public List<Cuenta_Bancaria> CuentasAjenasAlCliente(Cliente clienteABuscar)
        {
            var cuentasFiltradas = listaCuentasBancarias().Where(cuenta => cuenta.Cliente.ID != clienteABuscar.ID).ToList();

            return cuentasFiltradas;
        }


        public void RealizarDeposito(Cuenta_Bancaria cuenta, decimal monto)
        {
            if (cuenta != null)
            {
                cuenta.Saldo = cuenta.Saldo + monto;

                context.Cuentas_Bancarias.Update(cuenta);
                context.SaveChanges();
            }
        }


        public void RealizarExtraccion(Cuenta_Bancaria cuenta, decimal extraccion)
        {
            if (cuenta != null )
            {
                cuenta.Saldo = cuenta.Saldo - extraccion;

                context.Cuentas_Bancarias.Update(cuenta);
                context.SaveChanges();
            }
        }

        public void RealizarTransferencia(Cuenta_Bancaria cuentaOrigen, decimal montoTransferencia, Cuenta_Bancaria cuentaDesitno)
        {
            if (cuentaOrigen != null)
            {
                if (montoTransferencia <= cuentaOrigen.Saldo)
                {
                    cuentaOrigen.Saldo = cuentaOrigen.Saldo - montoTransferencia;
                    cuentaDesitno.Saldo = cuentaOrigen.Saldo + montoTransferencia;

                    context.Cuentas_Bancarias.Update(cuentaOrigen);
                    context.Cuentas_Bancarias.Update(cuentaDesitno);
                    context.SaveChanges();

                   // return $"Transferencia aprobada.\n\nMONTO: {montoTransferencia}\nCUENTA DESTINO:\nNro {cuentaDesitno.NroCuenta}\nTitular {cuentaDesitno.Cliente.Nombre}\nDNI {cuentaDesitno.Cliente.DNI}";
                        
                }
                else 
                {
                   // return "No contiene fondos suficientes";
                }
            }
            //return "";
        }


        // Metodo para unir las 2 tablas (cliente y ctaBancaria) y mostrar los datos de forma completa
        public DataTable CuentasBancarias()
        {
            var consulta = from cuenta in context.Cuentas_Bancarias
                           join cliente in context.Clientes
                           on cuenta.Cliente.ID equals cliente.ID
                           select new
                           {
                               cuenta.ID,
                               cliente.Nombre,
                               cliente.Apellido,
                               cuenta.NroCuenta,
                               cuenta.Saldo,
                               cuenta.Tipo,

                           };

            var listaConsulta = consulta.ToList();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Apellido", typeof(string));
            dataTable.Columns.Add("Numero Cuenta", typeof(decimal));
            dataTable.Columns.Add("Saldo Disponible", typeof(decimal));
            dataTable.Columns.Add("Tipo", typeof(string));


            foreach (var resultado in listaConsulta)
            {
                dataTable.Rows.Add(resultado.ID, resultado.Nombre, resultado.Apellido, resultado.NroCuenta, resultado.Saldo,
                    resultado.Tipo);
            }

            return dataTable;

        }


        // ---------------------------------------------------------------------------------- TARJETAS DE CREDITO

        public  void EmitirTarjetaCredito(Cliente cliente, decimal nroTarjeta, decimal limiteCredito, EstadoTarjetaCredito estado)
        {
            if (cliente != null)
            {
                Tarjeta_Credito tarjetaNew = new Tarjeta_Credito();

                tarjetaNew.Cliente = cliente;
                tarjetaNew.NroTarjeta = nroTarjeta;
                tarjetaNew.LimiteCredito = limiteCredito;
                tarjetaNew.SaldoDisponible = limiteCredito;
                tarjetaNew.MontoDeuda = 0;
                tarjetaNew.Estado = estado;


                context.Tarjetas_Credito.Add(tarjetaNew);   
                context.SaveChanges();
            }
        }

        // Baja logica tarjeta
        public void BajaTarjeta(Tarjeta_Credito tarjeta)
        {
            if (tarjeta != null)
            {
                tarjeta.Estado = EstadoTarjetaCredito.Pausada;
                context.Tarjetas_Credito.Update(tarjeta);
                context.SaveChanges();
            }
        }

        public void RealizarCompraConTarjeta (Tarjeta_Credito tarjeta, decimal precio, string detalle)
        {
            if (tarjeta != null)
            {
                if (precio <= tarjeta.SaldoDisponible) 
                {
                    tarjeta.MontoDeuda = tarjeta.MontoDeuda + precio;
                    tarjeta.SaldoDisponible = tarjeta.MontoDeuda  - precio;

                    comprasConTarjeta.Add($"{detalle} --------------------------- ${precio}");

                    context.Tarjetas_Credito.Update(tarjeta);
                    context.SaveChanges();

                    //return $"Compra realizada con exito.\n\nSaldo disponible: {tarjeta.SaldoDisponible}";

                }
                else
                {
                    //return $"La compra se excede del saldo disponible en la tarjeta.\n\nSaldo disponible: {tarjeta.SaldoDisponible}";
                }

            }
            //return "No se encontro la tarjeta";
        }
        public void PagarTarjeta(Tarjeta_Credito tarjeta, decimal pago)
        {
            if (tarjeta != null)
            {
                if (pago <= tarjeta.MontoDeuda) 
                {
                    tarjeta.MontoDeuda = tarjeta.MontoDeuda - pago;
                    tarjeta.SaldoDisponible = tarjeta.MontoDeuda + pago;

                    //return $"Pago aprobado.\n\nSaldo disponble actual: {tarjeta.SaldoDisponible}\nDeuda actual: {tarjeta.MontoDeuda}";
                }
                else
                {
                    //return $"Pago mayor a la deuda actual.\n\nDeuda actual {tarjeta.MontoDeuda}";
                }

            } //return "No se encontro la tarjeta";
        }


        public string ResumenTarjeta(Tarjeta_Credito tarjeta)
        {
            var tarjetaEncontrada = context.Tarjetas_Credito.Find(tarjeta);

            if (tarjetaEncontrada != null)
            {
                return $"RESUMEN TARJETA DE CREDITO NRO {tarjetaEncontrada.NroTarjeta}\nTitular: {tarjetaEncontrada.Cliente.Nombre + tarjetaEncontrada.Cliente.Apellido}\nDNI: {tarjetaEncontrada.Cliente.DNI}\n\n Credito otorgado: ${tarjetaEncontrada.LimiteCredito}" +
                    $"\nCredito disponible: ${tarjetaEncontrada.SaldoDisponible}\nMonto a abonar; ${tarjetaEncontrada.MontoDeuda}";
            }
            else
            {
                return "No se encontro la tarjeta ingresada";
            }
            
            
        }


        // Metodo para unir las 2 tablas (cliente y tarjetaCredito) y mostrar los datos de forma completa
        public DataTable ListadoCompletoTarjetas()
        {
            var consulta = from tarjeta in context.Tarjetas_Credito
                           join cliente in context.Clientes
                           on tarjeta.Cliente.ID equals cliente.ID
                           select new
                           {
                               tarjeta.ID,
                               cliente.Nombre,
                               cliente.Apellido,
                               tarjeta.NroTarjeta,
                               tarjeta.LimiteCredito,
                               tarjeta.SaldoDisponible,
                               tarjeta.Estado
                           };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Apellido", typeof(string));
            dataTable.Columns.Add("Nro Tarjeta", typeof(decimal));
            dataTable.Columns.Add("Limite Credito", typeof(decimal));
            dataTable.Columns.Add("Saldo Disponible", typeof(decimal));
            dataTable.Columns.Add("Estado", typeof(string));


            foreach (var resultado in consulta)
            {
                dataTable.Rows.Add(resultado.ID, resultado.Nombre, resultado.Apellido, resultado.NroTarjeta, resultado.LimiteCredito,
                    resultado.SaldoDisponible, resultado.Estado);
            }

            return dataTable;

        }



    }
}
