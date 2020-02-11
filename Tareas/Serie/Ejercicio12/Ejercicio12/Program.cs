using System;

namespace Ejercicio12
{
    class Program
    {
        //Main del programa. Aquí se hacen todos los loops para preguntar si se quieren
        //añadir más productos o si se desea relizar la compra.
        static void Main(string[] args)
        {
            string comprar = "n";
            string anadirProducto = "s";
            Compras compras = new Compras();

            
            
            Console.WriteLine("Lista de compras");

            while(anadirProducto == "s")
            {
                Console.Write("\nAñadir Productos? s/n: ");
                anadirProducto = Console.ReadLine();
                if (anadirProducto == "s")
                {
                    compras.AniadeProducto();
                }
            }
            string opcion;
            while (comprar != "s")
            {
                compras.MuestraLista();
                Console.WriteLine("\n\n1) Comprar");
                Console.WriteLine("2) Dejar productos");
                Console.Write("Escribe una opción: ");
                opcion = Console.ReadLine();
                if(opcion == "1")
                {
                    if (compras.Precio <= 500)
                    {
                        Console.WriteLine("Gracias por su compra!");
                        comprar = "s";
                    }
                    else
                    {
                        compras.DejarProductos();
                        compras.MuestraLista();
                    }
                }
                if (opcion == "2")
                {
                    compras.DejarProductos();
                    compras.MuestraLista();
                }

            }

            Console.ReadKey();
        }
    }
}
