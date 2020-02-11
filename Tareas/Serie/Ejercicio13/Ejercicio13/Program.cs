using System;

namespace Ejercicio13
{
    class Program
    {
        //Clase Main del programa en donde se crean dos objetos de las clases hijas de la clase Carro
        //y se prueban sus métodos
        static void Main(string[] args)
        {
            CarroBMW bmw = new CarroBMW("Serie 1 2020",800,Convert.ToDecimal(1.3));
            CarroVW vw = new CarroVW("Golf 2020", 600, Convert.ToDecimal(1.20));
            Console.WriteLine("Auto VW");
            vw.Encender();
            vw.Estado();
            vw.Apagar();
            vw.Estado();
            vw.Encender();
            vw.Estado();
            Console.WriteLine("{0}", vw.ToString());
            Console.WriteLine("\n\nAuto BMW");
            bmw.Estado();
            bmw.Apagar();
            bmw.Encender();
            bmw.Estado();
            Console.WriteLine("{0}",bmw.ToString());
            Console.ReadKey();
        }
    }
}
