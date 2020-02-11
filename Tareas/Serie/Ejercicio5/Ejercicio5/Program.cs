using System;
using System.Globalization;

namespace Ejercicio5
{
    class Program
    {
        //Método main del programa en el cual se hacen pruebas y se hace un if en donde se mandan a llamar 
        //los diferentes métodos de la clase "agenda".
        static void Main(string[] args)
        {
            string opcion = "0";
            string nombre,telefono;
            Console.WriteLine("Agenda");
            Agenda agenda = new Agenda();

            /*________PRUEBAS_____________*/
            Console.WriteLine("INICIO*PRUEBAS___________________________________");
            agenda.Agregar("Edgar", "5530291030");
            agenda.Agregar("Edgar 2", "6512312423");
            agenda.Agregar("Edgar 3", "7512312423");
            agenda.Agregar("Edgar", "5512312423");
            agenda.Mostrar();
            agenda.Eliminar("edgar");
            agenda.Eliminar("edgar 2");
            agenda.Eliminar("edgar3");
            agenda.Eliminar("edgar 3");
            agenda.Mostrar();
            Console.WriteLine("FIN*PRUEBAS___________________________________");
            /*____________________________*/
            while (opcion != "4")
            {
                Console.WriteLine("\n\t1) Agregar contacto\n\t2) Eliminar contacto\n\t3) Mostrar Contacto\n\t4) Salir");
                Console.Write("Escribe una opción: ");
                opcion = Console.ReadLine();

                if(opcion == "1")
                {
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    telefono = Console.ReadLine();
                    agenda.Agregar(nombre,telefono);
                }
                else if (opcion == "2")
                {
                    Console.Write("Escribe el nombre del contacto a eliminar: ");
                    nombre = Console.ReadLine();
                    agenda.Eliminar(nombre);
                }
                else if (opcion == "3")
                {
                    agenda.Mostrar();
                }
                else if (opcion == "4")
                {

                }
                else
                {
                    Console.WriteLine("Ingresa una opción correcta");
                }

            }


        }
    }
}
