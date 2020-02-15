using System;
using System.Linq;
using System.Collections.Generic;

namespace QuerySintaxis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 9, 5, 0, 3, 7, 4, 8, 5 };
            Console.WriteLine("Arreglo Original");
            Imprime(numeros);

            //query que obtiene los números mayores a 4
            var filtered =
                from n in numeros
                where n > 4
                select n;
            Console.WriteLine("Arreglo filtrado");
            Imprime(filtered);

            // Ordenar Arreglo
            var sorted =
                from n in numeros
                orderby n
                select n;
            Console.WriteLine("Arreglo ordenado ascendente");
            Imprime(sorted);

            var sortDesc =
                from n in numeros
                orderby n descending
                select n;
            Console.WriteLine("Arreglo ordenado descendente");
            Imprime(sortDesc);

            var sortFiltered =
                from n in filtered
                orderby n
                select n;
            Console.WriteLine("Arreglo ordenado ordenado y filtrado");
            Imprime(sortFiltered);


            string[] paises = { "México", "Rusia", "Chile", "Cuba", "Canadá", "Alemania","Perú" };

            //paises cuyo nombre contiene a,

            IEnumerable<string> query =
                from p in paises
                where p.Contains("a")
                orderby p.Length
                select p.ToUpper();
            Console.WriteLine("Paises ordenados por tamaño que contienen a");
            Imprime(query);     

            Console.ReadKey();

        }

        static void Imprime<T>(IEnumerable<T> arreglo)
        {
            foreach (var elemento in arreglo)
            {
                Console.WriteLine("{0} ",elemento);
            }
        }
    }
}
