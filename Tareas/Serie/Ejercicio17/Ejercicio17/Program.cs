using System;

namespace Ejercicio17
{
    class Program
    {
        //Main del programa en donde haremos las pruebas de las clases
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado(4);

            cuadrado.Presentacion();
            cuadrado.CalculaArea();
            cuadrado.CalculaPerimetro();

            Console.ReadKey();
        }
    }
}
