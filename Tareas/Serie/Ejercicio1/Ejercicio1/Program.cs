using System;

namespace Ejercicio1
{
    class Program
    {
        //Método Main del programa. Aquí se manda a llamar al método Suma de la clase SumaNNumeros.
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que suma n numeros naturales");
            Console.WriteLine("Ingresa un número natural para hacer la suma: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma desde 1 a {0} es: {1}",n,SumaNNumeros.Suma(n));
            Console.ReadKey();
        }
    }
}
