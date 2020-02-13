using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    //Clase que hereda de la clase FormaGeometrica
    //Tiene dos métodos que los sobreescribe de la clase padre
    class Cuadrado: FormaGeometrica
    {
        public override void Presentacion()
        {
            Console.WriteLine("Yo soy un cuadrado");
        }
        public override void Caracteristicas()
        {
            Console.WriteLine("Tengo un perimetro que se calcula lado * 4 y un perimetro que es la suma de mis 4 lados. Todos mis lados son iguales");
        }
    }
}
