using System;

namespace Ejercicio10
{
    class Program
    {
        //Main del programa en el cual se crean un par de objetos de la clase Persona y se les manda a llamar 
        //sus métodos Informacion, Presentar y Saludar
        static void Main(string[] args)
        {
            Persona persona = new Persona("Edgar Hdz", 29, 80, Convert.ToDecimal(1.6));

            Console.WriteLine("Método Informacion()");
            persona.Informacion();
            Console.WriteLine("\nMétodo Presentar()");
            persona.Presentar();
            Console.WriteLine("\nMétodo Saludar()");
            persona.Saludar();

            Persona persona2 = new Persona();
            Console.WriteLine("\nMétodo Informacion()");
            persona2.Informacion();
            Console.WriteLine("\nMétodo Presentar()");
            persona2.Presentar();
            Console.WriteLine("\nMétodo Saludar()");
            persona2.Saludar();

            Console.ReadKey();
        }
    }
}
