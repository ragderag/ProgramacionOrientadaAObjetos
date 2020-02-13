using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17
{
    //Clase cuadrado que hereda de la clase cuadrilatero
    class Cuadrado : Cuadrilatero
    {
        //Atributos de la clase;
        double lado;

        public double Lado { get; set; }
        

        //En estos dos métodos estamos haciendo uso del polimorfismo
        public override void CalculaArea()
        {
            Console.WriteLine("Mi área se calcula elevando al cuadrado uno de mis lados. Area: {0}",Area);
        }

        public override void CalculaPerimetro()
        {
            Console.WriteLine("Mi área se calcula multiplicando uno de mis lados * 4. Perímetro {0}", Perimetro);
        }

        //Constructor de la clase, recibe como parámetro uno de los lados del cuadrado y calcula el perímetro y área.
        public Cuadrado (double lado)
        {
            Lado = lado;
            Area = Lado * Lado;
            Perimetro = Lado * 4;
        }
    }
}
