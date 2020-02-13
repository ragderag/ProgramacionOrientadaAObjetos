using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    //Clase padre que tiene los métodos de Presentación y Características.
    //De esta clase van a heredar varias formas geómetricas en las cuales
    //se puede observar el polimorfimo. Sus métodos se pueden sobreescribir.
    class FormaGeometrica
    {

        //Método que indica que es una figura geómetrica
        public virtual void Presentacion()
        {
            Console.WriteLine("Soy una figura geométrica");
        }

        //Método que indica las caracterísitcas de la figura
        public virtual void Caracteristicas()
        {
            Console.WriteLine("Existo en el espacio y tengo area y perimetro");
        }
    }

}


