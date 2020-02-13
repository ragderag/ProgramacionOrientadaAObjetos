using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    //Interfaz que tiene como objetivo identificar los diferentes tipos de ángulos
    public interface IAngulo
    {
        //Tiene las características que indican cuánto mide cada ángulo para considerarse de algún tipo    
        string Caracteristicas();

        //Tiene un método calcular que verifica si un ángulo es o no de algún tipo
        bool Calcular();
    }
}
