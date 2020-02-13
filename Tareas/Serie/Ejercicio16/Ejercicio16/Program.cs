using System;

namespace Ejercicio16
{
    //Main del programa en la cual se crean un objeto de cada clase
    //Se muestran sus métodos y se puede observar cómo la figura cuadrado 
    //Tiene presentación y caracteristicas diferentes que la clase forma
    class Program
    {
        static void Main(string[] args)
        {
            FormaGeometrica forma = new FormaGeometrica();
            Cuadrado cuadrado = new Cuadrado();

            forma.Presentacion();
            forma.Caracteristicas();

            cuadrado.Presentacion();
            cuadrado.Caracteristicas();


            Console.ReadKey();
        }
    }
}
