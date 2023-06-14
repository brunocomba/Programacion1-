namespace Consola;
using LibreriaClases;
using LibreriaClases.Ejercicio1;
using LibreriaClases.Ejercicio2;
using LibreriaClases.Ejercicio3;
using LibreriaClases.EJercicio4;
using LibreriaClases.Ejercicio5;
using LibreriaClases.EjercicioOpcional;

internal class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("---- MENÚ ----");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine();
            Console.WriteLine("(1) Ejercicio 1. ");
            Console.WriteLine("(2) Ejercicio 2. ");
            Console.WriteLine("(3) Ejercicio 3. ");
            Console.WriteLine("(4) Ejercicio 4. ");
            Console.WriteLine("(5) Ejercicio 5. ");
            Console.WriteLine("(6) Ejercicio Opcional. ");
            Console.WriteLine("(7) Salir. ");

            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    // EJERCIO 1---
                    List<Animal> listAnimales = new List<Animal>();
                    listAnimales.Add(new Perro());
                    listAnimales.Add(new Gato());
                    listAnimales.Add(new Vaca());

                    // Recorro la lista (listAnimales) e imprimo por consola el metodo sonido animal
                    // (animal) es la variable que va iterando

                    foreach (Animal animal in listAnimales)
                    {
                        Console.WriteLine(animal.sonidoAnimal());
                    }
                    Console.WriteLine();
                    break;


                case 2:
                    // EJERCICIO 2---
                    List<IVehiculo> listaVehiculos = new List<IVehiculo>();
                    // Setiandole la velocidad y agregandolo a la lista
                    Auto auto = new Auto();
                    auto.Velocidad = 100;
                    Bicicleta bici = new Bicicleta();
                    bici.Velocidad = 20;
                    listaVehiculos.Add(auto);
                    listaVehiculos.Add(bici);

                    // Agregando a la lista sin setiarle la velocidad
                    listaVehiculos.Add(new Auto());
                    listaVehiculos.Add(new Bicicleta());

                    foreach (IVehiculo vehiculo in listaVehiculos)
                    {
                        Console.WriteLine(vehiculo.Acelerar());
                    }
                    Console.WriteLine();

                    break;

                case 3:
                    // EJERCICIO 3---
                    List<FiguraGeometrica> Figuras = new List<FiguraGeometrica>();
                    Circulo miCirculo = new Circulo();
                    miCirculo.Radio = 15;
                    miCirculo.Name = "Circulo";
                    Figuras.Add(miCirculo);
                    // Otra forma de imprimir el valor
                    Console.WriteLine(miCirculo.DecimeQuienSos());


                    Cuadrado miCuadrado = new Cuadrado();
                    miCuadrado.Lado = 29;
                    miCuadrado.Name = "Cuadrado";
                    Figuras.Add(miCuadrado);

                    Rectangulo miRect = new Rectangulo();
                    miRect.Altura = 19;
                    miRect.Base = 8;
                    miRect.Name = "Rectangulo";
                    Figuras.Add(miRect);

                    foreach (FiguraGeometrica figura in Figuras)
                    {
                        double area = figura.Area();
                        Console.WriteLine("El area del: " + figura.Name + " es de: " + area);

                    }
                    Console.WriteLine();
                    break;
                case 4:
                    // EJERCICIO 4---
                    List<Empleado> listaEmpleados = new List<Empleado>();

                    Gerente gerenteNew = new Gerente();
                    gerenteNew.nombre = "Bruno";
                    gerenteNew.salarioBase = 120000;
                    gerenteNew.bono = 17000;
                    listaEmpleados.Add(gerenteNew);

                    Vendedor vendedorNew = new Vendedor();
                    vendedorNew.nombre = "Martin";
                    vendedorNew.salarioBase = 90000;
                    vendedorNew.comision = 17000;
                    listaEmpleados.Add(vendedorNew);

                    foreach (Empleado empleado in listaEmpleados)
                    {
                        Console.WriteLine("El salario del empleado: " + empleado.nombre + " es de: " + empleado.CalcularSalario());
                    }
                    break;

                case 5:
                    // EJERCICIO 5---
                    List<InstrumentoMusical> listaInstrumentos = new List<InstrumentoMusical>();
                    listaInstrumentos.Add(new Guitarra());
                    listaInstrumentos.Add(new Piano());
                    listaInstrumentos.Add(new Bateria());

                    foreach (InstrumentoMusical instrumento in listaInstrumentos)
                    {
                        Console.WriteLine(instrumento.Tocar());
                    }
                    break;

                case 6:
                    // EJERCICIO OPCIONAL---
                    List<Producto> listaProductos = new List<Producto>();
                    //Agregando objeto a la clase ProductoFisico utilizando el constructor.
                    ProductoFisico prodFisico = new ProductoFisico("Notebook", 235000, 2.300m);
                    listaProductos.Add(prodFisico);
                    ProductoFisico prodFisico1 = new ProductoFisico("Termo", 42500, 1.100m);
                    listaProductos.Add(prodFisico1);

                    // Agregando objeto a la clase ProductoDigital utilizando el constructor.
                    ProductoDigital producDigital = new ProductoDigital("Cryptomoneda", 898000, 10);
                    listaProductos.Add(producDigital);
                    ProductoDigital producDigital1 = new ProductoDigital("Software", 120000, 12);
                    listaProductos.Add(producDigital1);

                    // Recorro la lista e imprimo la informacion de cada objeto
                    foreach (Producto prod in listaProductos)
                    {
                        Console.WriteLine("Nombre producto: " + prod.Nombre);
                        Console.WriteLine("Precio: $" + prod.Precio);
                        Console.WriteLine("Impuesto: $" + prod.CalcularImpuesto());
                        Console.WriteLine("Total a pagar: $" + prod.CalcularTotal());
                        Console.WriteLine();
                    }
                    break;

                case 7:
                    Console.WriteLine("Saliendo del programa... ");
                    break;

                default:

                    Console.WriteLine("Opcion invalida. Vuelva a intentar. ");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para continuar... ");
            Console.ReadKey();
            Console.Clear();

        } while (opcion != 7);



        
 

    

       

        
    }
}