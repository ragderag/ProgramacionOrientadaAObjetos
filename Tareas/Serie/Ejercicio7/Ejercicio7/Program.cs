using System;

namespace Ejercicio7
{
    class Program
    {
        //Main del programa
        //Se crean dos objetos y se manda a llamar a su método ImprimeNumero
        //después se suman y se muestra el resultado.
        static void Main(string[] args)
        {
            Console.WriteLine("Números Complejos");

            Console.WriteLine("Creación de dos números complejos");
            NumeroComplejo n1 = new NumeroComplejo(5, 6);
            NumeroComplejo n2 = new NumeroComplejo(10, -10);

            n1.ImprimeNumero();
            n2.ImprimeNumero();

            Console.Write("\nSuma de: \n   ");
            n1.ImprimeNumero();
            Console.Write("+ ");
            n2.ImprimeNumero();

            Console.WriteLine("\nResultado:");
            NumeroComplejo resultado = NumeroComplejo.Suma(n1, n2);
            resultado.ImprimeNumero();

            Console.ReadKey();
        }
    }
}