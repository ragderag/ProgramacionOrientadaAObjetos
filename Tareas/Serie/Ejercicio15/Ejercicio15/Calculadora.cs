using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio15
{
    //Clase Calculadora que implementa la suma, resta, division y multiplicacion de dos números
    class Calculadora
    {
        //Tiene como atributos dos números
        double numero1, numero2;

        //Getters y Setters de los atributos
        public double Numero1
        {
            get { return numero1; }
            set { numero1 = value; }
        }

        public double Numero2
        {
            get { return numero2; }
            set { numero2 = value; }
        }

        //Método para leer los valores de numero1 y numero2
        public void IngresaNumeros()
        {
            try
            {
                Console.WriteLine("Ingresa el primer numero");
                Numero1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("No se pudo establecer el valor que ingresaste");
                Console.WriteLine("Default = 0");
            }
            try
            {
                Console.WriteLine("Ingresa el segundo numero");
                Numero2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("No se pudo establecer el valor que ingresaste");
                Console.WriteLine("Default = 0");
            }
        }

        //Método suma que suma los dos atributos del objeto
        public void Suma()
        {
            IngresaNumeros();
            try { Console.WriteLine("{0} + {1} = {2}", Numero1, Numero2, Numero1 + Numero2); }
            catch (Exception) { Console.WriteLine("Hubo un error"); }
        }

        //Método Resta que resta los dos atributos del objeto
        public void Resta()
        {
            IngresaNumeros();
            try { Console.WriteLine("{0} - {1} = {2}", Numero1, Numero2, Numero1 - Numero2); }
            catch (Exception) { Console.WriteLine("Hubo un error"); }
        }

        //Método Multiplicación que multiplica los dos atributos de la clase
        public void Multiplicacion()
        {
            IngresaNumeros();
            try { Console.WriteLine("{0} * {1} = {2}", Numero1, Numero2, Numero1 * Numero2); }
            catch (Exception) { Console.WriteLine("Hubo un error"); }
        }

        //Método división que multiplica los dos atributos de la clase
        public void Division()
        {
            IngresaNumeros();
            try { Console.WriteLine("{0} / {1} = {2}", Numero1, Numero2, Numero1 / Numero2); }
            catch (Exception) { Console.WriteLine("Hubo un error"); }
        }

    }
}
