using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    //Clase Carro que tiene los métodos Encender, Apagar, Estado y ToString
    class Carro
    {
        //Atributos de la clase carro. Tiene peso, altura y un booleano para
        //ver si está encendido o apagado.
        decimal peso;
        decimal altura;
        bool encendido = false;

        //Getter y Setters de los atributos de la clase
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public bool Encendido { get; set; }


        //Constructor de la clase, recibe el peso y altura.
        public Carro(decimal peso, decimal altura)
        {
            Peso = peso;
            Altura = altura;
        }

        //Método de la clase que enciende el carro
        public void Encender()
        {
            Console.WriteLine("El auto se encendió");
            Encendido = true;
        }

        //Método que apaga el carro
        public void Apagar()
        {
            Console.WriteLine("El auto se apagó");
            Encendido = false;
        }

        //Método que muestra si el carro está encendido o apagado
        public bool Estado()
        {
            if (Encendido)
            {
                Console.WriteLine("El auto está encendido");
            }
            else
            {
                Console.WriteLine("El auto está apagado");
            }
            return Encendido;
        }

        //Método ToString sobre escrito para mostrar información del objeto
        public override string ToString()
        {
            return String.Format("El peso del auto es {0} kg y la altura son {1} metros", Peso, Altura);
        }

    }
}
