using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    //Clase que hereda de la clase Carro
    class CarroBMW: Carro
    {
        //Atributos del carro tipo BMW
        string modelo;

        //Get y Set del atributo modelo
        public string Modelo { get; set; }
        
        //Constructor que recibe el modelo del auto y también el peso y altura que son necesarias
        //por parte de la clase Carro de la cual heredó
        public CarroBMW(string modelo, decimal peso, decimal altura) : base(peso, altura)
        {
            Modelo = modelo;
        }

        //Método sobre escrito ToString
        public override string ToString()
        {
            return String.Format("El peso del auto BMW modelo {0} es {1} kg y la altura son {2} metros", Modelo, Peso, Altura);
        }


    }
}
