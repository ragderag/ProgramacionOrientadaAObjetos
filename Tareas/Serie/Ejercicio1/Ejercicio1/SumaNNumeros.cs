using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    /*Clase que tiene un método estático que se
     encargará de realizar la suma de los n numeros naturales*/
    class SumaNNumeros
    {
        //Método estático que recibe un número entero
        //con este número se hace la suma desde 
        //i=0 hasta el número recibido.
        public static int Suma(int n)
        {
            int k = 0;
            for (int i = 0; i <=n; i++)
            {
                k += i;
            }
            
            return k;
        }
    }
}
