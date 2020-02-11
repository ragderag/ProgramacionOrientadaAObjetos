using System;

namespace Ejercicio3
{
    class Program
    {
        //main del programa.
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que recibe una cadena y antes de cada vocal escribe una \"f\"");
            Console.Write("Escribe una cadena: ");
            string cadena = Console.ReadLine();
            Console.WriteLine("\nCadena Orginal: {0}\nCadena con f's: {1}",cadena,Reemplazar(cadena));
            Console.ReadKey();
        }

        /*Método que recibe una cadena en la cual va a poner una "f" antes de cada vocal.
          Regresa una cadena con las sustituciones hechas.*/
        static string Reemplazar(string cadena)
        {
            string reemplazar = "AEIOUaeiou",temp;
            temp = cadena;
            for (int i = 0; i < reemplazar.Length; i++)
            {
                string oldValue = Convert.ToString(reemplazar[i]);
                string newValue = "f" + Convert.ToString(reemplazar[i]);
                temp=temp.Replace(oldValue, newValue);
            }
            return temp;
        }
    }
}