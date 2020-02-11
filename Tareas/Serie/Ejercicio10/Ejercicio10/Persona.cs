using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10
{
    //Clase Persona que tiene 3 métodos. Saludar, Presentar e Informacion.
    class Persona
    {
        //Atributos de la Clase Persona
        //Se declara el nombre, edad, estatura y peso.
        string nombre;
        int edad;
        decimal estatura;
        decimal peso;

        //Getters y Setters de los atributos.
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Estatura { get; set; }
        public decimal Peso { get; set; }

        //Método Saludar que te dice su nombre y te pide el tuyo y te saluda.
        public void Saludar()
        {
            Console.Write("Hola, mi nombre es {0}\nCómo te llamas? (escribe tu nombre) ",Nombre,Edad);
            Console.WriteLine("Hola {0}!", Console.ReadLine());
        }

        //Método Presentar que imprime en pantalla el nombre, edad, peso y estatura.
        public void Presentar()
        {
            Console.WriteLine("Soy {0}, tengo {1} años, peso {2} kg y mido {3} m", Nombre, Edad, Peso, Estatura);
        }

        //Método Informacion que despliega la información del objeto
        public void Informacion()
        {
            Console.WriteLine("Nombre: {0}\nEdad: {1} años\nPeso: {2} kg \nEstatura: {3} m", Nombre, Edad, Peso, Estatura);
        }

        //Constructor de la clase Persona. Te pide todos los datos para que los ingreses por consola.
        public Persona () 
        {
            Console.Write("¿Cuál es tu nombre? ");
            Nombre = Console.ReadLine();
            Console.Write("¿Qué edad tienes? ");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Cuánto pesas en kilogramos? ");
            Peso = Convert.ToDecimal(Console.ReadLine());
            Console.Write("¿Cuánto mides en metros? ");
            Estatura = Convert.ToDecimal(Console.ReadLine());
        }

        //Sobrecarga del constructor. Sólo le pasas los argumentos al momento de crear el objeto.
        public Persona ( string nombre, int edad, decimal peso, decimal estatura)
        {
            Nombre = nombre;
            Edad = edad;
            Peso = peso;
            Estatura = estatura;
        }
    }
}
