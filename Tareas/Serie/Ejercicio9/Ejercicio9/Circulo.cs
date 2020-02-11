using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    //Clase Circulo que tiene como atributos el radio y el área, también se define la variable PI extraída
    //de la clase Math
    class Circulo
    {
        //Declaración de variables para la 
        //clase. Se declara radio para recibir el radio del objeto
        //También tiene el atributo area.
        double radio;
        double area;
        public double pi = Math.PI;

        //Get y Set de radio
        public float Radio { get; set; }

        //Método que calcula el área del círculo, aquí se una el métod Pow de la clase Math
        public double Area() 
        {
            area = pi * Math.Pow(Radio, 2);
            return area;
        }

        //Métod que calcula el área aproximada del círculo, aquí se usa el método Round y Pow de la clase Math
        public double AreaAproximada()
        {
            return Math.Round(pi * Math.Pow(Radio, 2));
        }

        //Método que calcula el perímetro del círculo
        public double Perimetro()
        {
            return (2 * pi * Radio);
        }

        //Método que calcula el perímetro aproximado del círculo. Aquí se usa el método Round de la clase Math
        public double PerimetroAproximado()
        {
            return Math.Round(2 * pi * Radio);
        }
        public Circulo(float radio) 
        {
            Radio = radio;
        }
    }
}
