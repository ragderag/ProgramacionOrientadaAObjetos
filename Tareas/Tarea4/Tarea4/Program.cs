using System;
using System.Collections.Generic;
using System.IO;

namespace Tarea4
{
    class Program
    {
        //Main del programa que manda a llamar los métodos de la clase ExploradorArchivos
        static void Main(string[] args)
        {
            //Atributos del método Main
            //el atributo linea sirve para guardar lo que ingresa el usuario y lo procesa después
            //el arreglo command sirve para descomponer la linea recibida desde consola
            //la lista "historia" guarda el historial de comandos ejecutados
            string linea;
            string[] command;
            List<string> historia = new List<string>();
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            if (! Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)))
            {
                Console.WriteLine("No se pudo encontrar la carpeta de Documentos");
                return;
            }            
            while (true) 
            {
                Console.Write("{0}> ", Directory.GetCurrentDirectory());
                linea = Console.ReadLine();
                command = linea.Split(' ', 2);

                switch (command[0].ToLower())
                {
                    case "dir":
                        {
                            ExploradorArchivos.dir(command);
                            break;
                        }
                    case "cd":
                        {
                            ExploradorArchivos.cd(command);
                            break;
                        }
                    case "touch":
                        {
                            ExploradorArchivos.touch(command);
                            break;
                        }
                    case "move":
                        {
                            ExploradorArchivos.move(command);
                            break;
                        }
                    case "history":
                        {
                            ExploradorArchivos.history(command,historia);
                            
                            break;
                        }
                    case "cls":
                        {
                            ExploradorArchivos.cls(command);
                            break;
                        }
                    case "exit":
                        {
                            if (command.Length == 1)
                                return;
                            else
                                Console.WriteLine("Demasiados argumentos para el comando exit");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Comando \"{0}\" inválido", command[0]);
                            break;
                        }
                }
                historia.Add(linea);
            }
        }
    }
}
