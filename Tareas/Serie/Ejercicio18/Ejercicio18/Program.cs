using System;
using System.IO;
using System.Text;

namespace Ejercicio18
{
    class Program
    {
        //Programa que lee un archivo o lo escribe
        static void Main(string[] args)
        {
            //Bucle para elegir una opción = abrir/escribir/salir 
            Console.WriteLine("Manejo de archivos");
            string opcion = "0";
            while(opcion != "3")
            {
                Console.Write("\n\t1) Leer Archivo\n\t2) Escribir en un archivo\n\t3) Salir\nElige una opcion: ");
                opcion = Console.ReadLine();
                if (opcion=="1")
                {
                    leer();
                }
                else if (opcion == "2")
                {
                    escribrir();
                }
            }
        }

        //Método que pide la ruta del archivo y si se puede abrir/leer el archivo lo despiega en pantalla
        static void leer()
        {
            Console.WriteLine("\nIngresa el nombre o la ruta del archivo .txt a leer (sin extensión)");
            string path = Console.ReadLine() + ".txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    Console.WriteLine("_______{0}__________",path);
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("__________________________________________");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("El archivo no existe o no se pudo abrir");
            }
        }

        //Método que escribe en un archivo. Pide la ruta absoluta o relativa del programa.
        static void escribrir()
        {
            Console.WriteLine("Ingresa el nombre del archivo (ruta absoluta o realativa) en el que se guardará el texto (sin extensión)");
            string path = Console.ReadLine() + ".txt";

            using (FileStream fs = File.Create(path, 1024))
            {
                Console.WriteLine("Escribe texto a ingresar al archivo:");
                byte[] info = new UTF8Encoding(true).GetBytes(Console.ReadLine());
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
