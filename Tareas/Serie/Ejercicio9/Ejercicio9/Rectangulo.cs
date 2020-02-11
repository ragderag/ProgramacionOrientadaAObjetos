using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    //Clase Rectangulo que tiene los métodos de Información, Area y Perimetro, tiene como atributos
    //lado1, lado2 para representar los lados de un rectángulo
    //También tiene como atributos perimetro y area.
    class Rectangulo
    {
        //Declaración de atributos.
        float lado1, lado2, perimetro, area;

        //Getter y Setters para lado1 y lado2
        public float Lado1 { get { return lado1; } set { lado1 = value; } }
        public float Lado2 { get { return lado2; } set { lado2 = value; } }
        
        //Método que calcula el perimetro del rectangulo. No recibe nada
        //y devuelve un float
        public float Perimetro()
        {
            perimetro = Lado1 * 2 + Lado2 * 2;
            return perimetro;
        }
        
        //Método que calcula el área de un rectángulo. No recibe nada
        //y devuelve un float
        public float Area()
        {
            area = Lado1 * Lado2;
            return area;
        }

        //Método que muestra la información del rectángulo. Muestra qué lado es mayor y qué lado es menor
        //Aquí se se usa el método Max y Min de la clase Math para saber qué lado es mayor y qué lado es menor.
        public void Informacion()
        {
            Console.WriteLine("Soy un rectángulo, mi lado mayor es {0} y mi lado menor es {1}", Math.Max(Lado1, Lado2), Math.Min(Lado1, Lado2));
            Console.WriteLine("Mi perimetro es {0} y mi área es {1}", Perimetro(), Area());
        }

        //Constructor de la clase. Recibe dos números flotantes.
        public Rectangulo(float lado1, float lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }
    }
}
