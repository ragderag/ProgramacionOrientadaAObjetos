using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    //Clase que tiene un método que se encargará de verificar si los números son múltiplos
    //o contienen a num1 y num2 imprimirá clap
    class ImprimeNumero
    {
        //Variables que va a recibir el método Imprime()
        int num1, num2;

        //Getter y Setters para num1 y num2
        public int Num1
        {
            get { return num1; }
            set
            {
                int temp = value;
                if (value <= 9 && value >=1)
                {
                    num1 = value;
                }
                else
                {
                    while(temp >9 || temp < 1)
                    {
                        Console.Write("Ingresa un número en el rango (1,9): ");
                        temp = Convert.ToInt32(Console.ReadLine());
                        num1 = temp;
                    }
                }
            }
        }

        public int Num2
        {
            get { return num2; }
            set
            {
                int temp = value;
                if (value <= 9 && value >= 1)
                {
                    num2 = value;
                }
                else
                {
                    while (temp > 9 || temp < 1)
                    {
                        Console.Write("Ingresa un número en el rango (1,9): ");
                        temp = Convert.ToInt32(Console.ReadLine());
                        num2 = temp;
                    }
                }
            }
        }
        //Clase que busca a num1 o num2 en la serie o busca si "i" es múltiplo de n1 o n2
        public void Imprime()
        {
            string str;
            for (int i = 1; i <= 100; i++)
            {
                if (Convert.ToString(i).Contains(Convert.ToString(Num1)) || Convert.ToString(i).Contains(Convert.ToString(Num2)))
                {
                    Console.WriteLine("clap");
                }
                else if ( i % Num1 == 0 || i % Num2 == 0 )
                {
                    Console.WriteLine("clap");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
