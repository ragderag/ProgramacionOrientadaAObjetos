using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    //Clase que tiene un método estático que se encarga de calcular la serie de fibonacci de "n" numeros
    class Fibonacci
    {
        //Clase estática que recibe un número entero que representa cuántos números se van a imprimir en 
        //pantalla de la serie de fibonacci. No devuelve nada.
        public static void FibonacciSerie(int numero)
        {
            for(double i = 0 , j=-1, k=1, temp=0; i<numero; i++)
            {
                temp = j + k;
                j = k;
                k = temp;
                Console.WriteLine("{0:0}",k);
            }
        }
    }
}
