using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio11
{
    class Matriz<T> 
    {
        <T>[] matriz;

        public void imprimeMatriz()
        {
            for( int j = 0; j < matriz.Length; j++) 
            {
                for ( int k = 0; k < matriz.Length; k++)
                {
                    Console.Write("{0}\t", matriz[j,k]);
                }
                Console.WriteLine();
            }
        }
        public Matriz(int i)
        {
            int[,] matriz = new int[i,i];
            for ( int temp = 0; temp < i; temp++ )
            {
                for ( int temp2 = 0; temp2 < i; temp2++ )
                {
                    Console.Write("Ingresa el elemento {0},{1}: ",temp,temp2);
                    try
                    {
                        matriz[temp, temp2] = Convert.ToDouble(Console.ReadLine());
                    } catch (Exception) { }
                    
                    try
                    {
                        matriz[temp, temp2] = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception) { }
                    
                    try
                    {
                        matriz[temp, temp2] = Convert.ToFloat(Console.ReadLine());
                    }
                    catch (Exception) { }

                }
            }

        }

    }
}
