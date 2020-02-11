using System;

namespace Ejercicio8
{
    class Program
    {
        //Método Main del programa.
        //Las pruebas son con 3 autos, el primero usa el primer constructor que sólo recibe la marca y el modelo del auto
        //los siguientes dos autos se construyen a partir del segundo constructor que recibe marca, subMarca, color y modelo del auto.
        //A continuación se despliega la información de cada auto creado usando los métodos get de cada atributo.
        //Primero se realizan pruebas con el auto1 en el cual se enciende, se pone a avanzar, se detiene y se llenan los atributos subMarca y color.
        //Después con el auto2 se avanza estando apagado el auto, luego se enciende, avanza, apaga y se modifica el atributo color
        //Por último con el auto3 se apaga, se detienen y se modifica el atributo modelo.
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Chevrolet", 2019);
            Auto auto2 = new Auto("Toyota", "Corolla", "Gris", 2020);
            Auto auto3 = new Auto("Nissan", "Versa", "Azul", 2017);

            Console.WriteLine("Auto 1 Marca: {0}, Submarca: {1}, Color: {2}, Modelo: {3}", auto1.Marca,auto1.SubMarca,auto1.Color,auto1.Modelo);
            Console.WriteLine("Auto 2 Marca: {0}, Submarca: {1}, Color: {2}, Modelo: {3}", auto2.Marca, auto2.SubMarca, auto2.Color, auto2.Modelo);
            Console.WriteLine("Auto 3 Marca: {0}, Submarca: {1}, Color: {2}, Modelo: {3}\n", auto3.Marca, auto3.SubMarca, auto3.Color, auto3.Modelo);

            
            auto1.Encender();
            auto1.Avanzar();
            auto1.Detener();
            auto1.SubMarca = "Aveo";
            auto1.Color = "Blanco";
            Console.WriteLine("Auto 1 Marca: {0}, Submarca: {1}, Color: {2}, Modelo: {3}\n", auto1.Marca, auto1.SubMarca, auto1.Color, auto1.Modelo);

            auto2.Avanzar();
            auto2.Encender();
            auto2.Avanzar();
            auto2.Apagar();
            auto2.Color = "Azul";
            Console.WriteLine("Auto 2 Marca: {0}, Submarca: {1}, Color: {2}, Modelo: {3}\n", auto2.Marca, auto2.SubMarca, auto2.Color, auto2.Modelo);
            
            auto3.Apagar();
            auto3.Detener();
            auto3.Modelo = 2020;
            Console.WriteLine("Auto 3 Marca: {0}, Submarca: {1}, Color: {2}, Modelo: {3}\n", auto3.Marca, auto3.SubMarca, auto3.Color, auto3.Modelo);

            Console.ReadKey();
        }
    }
}