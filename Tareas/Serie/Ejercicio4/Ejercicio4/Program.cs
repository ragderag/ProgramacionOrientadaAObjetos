using System;

namespace Ejercicio4
{
    class Program
    {
        //Método main del programa. Aquí se pide el número de elementos de la serie de fibonacci a calcular
        static void Main(string[] args)
        {
            Console.WriteLine("Serie de que imprime los n numeros de la serie de Fibonacci");
            Console.Write("Escribe la cantidad de números de la serie a calcular: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Fibonacci.FibonacciSerie(n);
            Console.ReadKey();
        }
    }
}
