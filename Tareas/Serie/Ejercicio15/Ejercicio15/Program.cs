using System;

namespace Ejercicio15
{
    class Program
    {
        //Main del programa. Aquí se implementa el loop que manda a llamar a los métodos de 
        //la clase Calculadora después de cada opción que elija el usuario
        static void Main(string[] args)
        {
            string opcion = "0";
            Calculadora calculadora = new Calculadora();
            Console.WriteLine("Calculadora");
            
            while (opcion != "5")
            {
                Console.Write("\n\t1) Suma\n\t2) Resta\n\t3) Multiplicación\n\t4) División\n\t5) Salir\nIngresa una opción: ");
                opcion=Console.ReadLine();
                if (opcion=="1")
                {
                    calculadora.Suma();
                }
                if (opcion == "2")
                {
                    calculadora.Resta();
                }
                if (opcion == "3")
                {
                    calculadora.Multiplicacion();
                }
                if (opcion == "4")
                {
                    calculadora.Division();
                }
                if (opcion == "5")
                {
                    return;
                }
            }
        }
    }
}
