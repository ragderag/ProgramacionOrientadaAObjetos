using System;

namespace Ejercicio14
{
    class Program
    {
        //Método Main en donde se hacen las pruebas de las clases
        //Se mandan a crear dos objetos de cada clase y se le asigna un angulo
        //Después se manda a llamar a cada uno el método Calcular para ver si es o no del tipo que se declaró
        static void Main(string[] args)
        {
            Llano llano = new Llano();
            Llano llano2 = new Llano();
            Obtuso obtuso = new Obtuso();
            Obtuso obtuso2 = new Obtuso();
            Recto recto = new Recto();
            Recto recto2 = new Recto();
            Agudo agudo = new Agudo();
            Agudo agudo2 = new Agudo();

            llano.Angulo = 180;
            llano2.Angulo = 30;
            obtuso.Angulo = 40;
            obtuso2.Angulo = 140;
            recto.Angulo = 10;
            recto2.Angulo = 90;
            agudo.Angulo = 10;
            agudo2.Angulo = 91;

            Console.WriteLine();
            Console.WriteLine("Llano: {0}", llano.Caracteristicas());
            Console.WriteLine("Ángulo {0}, llano = {1}", llano.Angulo, llano.Calcular());
            Console.WriteLine("Ángulo {0}, llano = {1}", llano2.Angulo, llano2.Calcular());
            Console.WriteLine();
            Console.WriteLine("Obtuso: {0}", obtuso.Caracteristicas());
            Console.WriteLine("Ángulo {0}, obtuso = {1}", obtuso.Angulo, obtuso.Calcular());
            Console.WriteLine("Ángulo {0}, obtuso = {1}", obtuso2.Angulo, obtuso2.Calcular());
            Console.WriteLine();
            Console.WriteLine("Recto: {0}", recto.Caracteristicas());
            Console.WriteLine("Ángulo {0}, recto  = {1}", recto.Angulo, recto.Calcular());
            Console.WriteLine("Ángulo {0}, recto  = {1}", recto2.Angulo, recto2.Calcular());
            Console.WriteLine();
            Console.WriteLine("Agudo: {0}", agudo.Caracteristicas());
            Console.WriteLine("Ángulo {0},  agudo= {1}", agudo.Angulo, agudo.Calcular());
            Console.WriteLine("Ángulo {0},  agudo= {1}", agudo2.Angulo, agudo2.Calcular());


            Console.ReadKey();
        }
    }
}
