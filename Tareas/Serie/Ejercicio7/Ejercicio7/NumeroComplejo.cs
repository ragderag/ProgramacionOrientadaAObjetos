using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    //Clase que representa un número complejo. Tiene los métodos ImprimeNumero y el método estático Suma para sumar dos números complejos
    class NumeroComplejo
    {
        //Atributos de la clase. parteReal para representar la parte real inicializada en cero
        //y parteImaginaria para representar la parte imaginaria inicializada en cero
        float parteReal = 0;
        float parteImaginaria = 0;

        //Getter y Setter de los atributos parteReal y parteImaginara.
        float ParteReal { get; set; }
        float ParteImaginaria { get; set; }


        //Método imprime numero que se encarga de formatear la salida para que se represente
        //como a + bi
        public void ImprimeNumero()
        {
            if ( ParteImaginaria >= 0 ) { Console.WriteLine("{0} + {1}i",ParteReal,ParteImaginaria); }
            else { Console.WriteLine("{0} - {1}i", ParteReal, ParteImaginaria*-1); }
        }

        //Constructor de la clase
        public NumeroComplejo() { }

        //Sobrecarga del constructor que recibe dos números flotantes, pR para la parte real
        //y pI para laparte imaginaria
        public NumeroComplejo(float pR, float pI)
        {
            ParteReal = pR;
            ParteImaginaria = pI;
        }
        //Método estático que se encarga de sumar dos objetos de tipo NumeroComplejo y 
        //devuelve un objeto del tipo NumeroComplejo.
        public static NumeroComplejo Suma(NumeroComplejo n1, NumeroComplejo n2)
        {
            NumeroComplejo resultado = new NumeroComplejo();
            resultado.ParteReal = n1.ParteReal + n2.ParteReal;
            resultado.ParteImaginaria = n1.ParteImaginaria + n2.ParteImaginaria;

            return resultado;
        }
    }
}
