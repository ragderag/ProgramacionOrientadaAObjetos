using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17
{
    class Cuadrilatero
    {
        //Estos métodos privados sirven para demostrar el pilar de la encapsulación
        private double area,perimetro;

        //Getters y Setters de los métodos privados que sirven para demostrar la encapsulación
        public double Area { get; set;}
        public double Perimetro { get; set; }


        public void Presentacion() 
        {
            Console.WriteLine("Hola, soy un cuadrilatero!");
        }

        //En este método se está haciendo presencia el polimorfismo, ya que se 
        //puede reescribir este fragmento de código para calcular el área de un cuadrilatero
        public virtual void CalculaArea()
        {
            Console.WriteLine("Mi area se calcula multiplicando dos de mis lados");
        }
        //En este método estamos aplicando el polimorfismo para calcular el perimetro de un cuadrilatero
        public virtual void CalculaPerimetro()
        {
            Console.WriteLine("Mi perimetro se calcula sumando mis cuatro lados");
        }

        //Constructor de la clase
        public Cuadrilatero() { }
    }
}
