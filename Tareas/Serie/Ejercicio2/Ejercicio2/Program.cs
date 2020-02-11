using System;

namespace Ejercicio2
{
    class Program
    {
        //Main del programa, aquí se piden el par de números para mandar a llamar al método Imprime de la clase ImprimeNumero.
        static void Main(string[] args)
        {
            ImprimeNumero imprime = new ImprimeNumero();
            Console.WriteLine("Programa que imprime números del 1 al 100\nImprime \"clap\" si algún número que se ingrese es múltiplo o contiene algún número ingresado");
            Console.Write("Escribe el primer número: ");
            imprime.Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe el segundo número: ");
            imprime.Num2 = Convert.ToInt32(Console.ReadLine());
            imprime.Imprime();
            Console.ReadKey();
        }
    }
}
