using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    //Clase que hereda de la clase Carro
    class CarroVW : Carro
    {
        //Atributo de la clase CarroVW
        string modelo;

        //Get y Set del atributo modelo
        public string Modelo { get; set; }

        //Constructor de la clase. Recibe el modelo del auto y 
        //el peso y altura que son necesarios para la clase padre.
        public CarroVW(string modelo, decimal peso, decimal altura) : base(peso, altura)
        {
            Modelo = modelo;
        }

        //Método sobreescrito de ToString
        public override string ToString()
        {
            return String.Format("El peso del auto VW modelo {0} es {1} kg y la altura son {2} metros",Modelo, Peso, Altura);
        }

    }
}
