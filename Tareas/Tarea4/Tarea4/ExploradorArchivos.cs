using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea4
{
    class ExploradorArchivos
    {
        //Dir: muestra el contenido de un directorio, si no recibe argumento muestra 
        //el directorio actual, en caso contrario muestra el directorio especificado.
        public static void dir(string[] command)
        {
            if (command.Length > 1)
            {
                string temp1 = command[1];
                temp1 = temp1.Replace("\"", "");
                if (Directory.Exists(temp1))
                {
                    Console.WriteLine("CARPETAS:");
                    foreach (var cadena in Directory.EnumerateDirectories(temp1))
                    {
                        string[] temp = cadena.Split("\\");
                        Console.WriteLine(temp[temp.Length - 1]);
                    }
                    Console.WriteLine("ARCHIVOS:");
                    foreach (var cadena in Directory.EnumerateFiles(temp1))
                    {
                        string[] temp = cadena.Split("\\");
                        Console.WriteLine(temp[temp.Length - 1]);
                    }
                }
                else { Console.WriteLine("No existe el directorio {0}",command[1]); }
            }
            else
            {
                Console.WriteLine("CARPETAS:");
                foreach (var cadena in Directory.EnumerateDirectories(Directory.GetCurrentDirectory()))
                {
                    string[] temp = cadena.Split("\\"); 
                    Console.WriteLine(temp[temp.Length - 1]);
                }
                Console.WriteLine("ARCHIVOS:");
                foreach (var cadena in Directory.EnumerateFiles(Directory.GetCurrentDirectory()))
                {
                    string[] temp = cadena.Split("\\");
                    Console.WriteLine(temp[temp.Length - 1]);
                }
            }
        }

        //Cd: cambia de directorio, puede recibir como argumento el nombre del directorio 
        //al que queremos cambiar o “..” que indican cambiar al directorio padre.
        public static void cd(string[] command)
        {
            if (command.Length > 1)
            {
                string temp = command[1].Replace("\"", "");
                
                if (command[1]=="..")
                {
                    Directory.SetCurrentDirectory("..");
                }
                else if (Directory.Exists(temp))
                {
                    Directory.SetCurrentDirectory(temp);
                }
                else
                {
                    Console.WriteLine("El directorio {0} no existe", command[1]);
                }
            }
            else
            {
                Console.WriteLine("El comando \"cd\" recibe un parámetro");
            }
        }

        //Touch: crea un archivo, recibe como argumento la ruta del archivo a crear, si es la ruta relativa
        //el archivo se crea en el directorio actual.
        public static void touch(string[] command)
        {
            if (command.Length > 1)
            {
                string temp = command[1].Replace("\"", "");
                if (File.Exists(temp))
                {
                    Console.WriteLine("El archivo ya existe");
                }
                else
                {
                    if (Directory.GetParent(temp).Exists)
                    {
                        try
                        {
                            File.Create(temp);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("{0}", e.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("El directorio no existe");
                    }
                }
            }
            else
                Console.WriteLine("Muy pocos argumentos para el comando \"touch\"");
        }

        //Move: mueve un archivo de un directorio a otro, recibe dos argumentos, el primero es el
        //archivo que queremos copiar y el segundo es a qué directorio se moverá.
        public static void move(string[] command)
        {
            string[] carpeta;
            string[] separator = { " \"","\" ", "\"" };
            if (command.Length == 2)
            {
                string origen;
                string destino;
                string destinoFile;
                carpeta = command[1].Split( separator, StringSplitOptions.RemoveEmptyEntries);
                if (carpeta.Length == 2)
                {
                    origen = carpeta[0];
                    destino = carpeta[1];
                    destinoFile = string.Format("{0}\\{1}", destino, origen.Split("\\")[origen.Split("\\").Length - 1]);
                }
                else if (command[1].Split(" ", StringSplitOptions.RemoveEmptyEntries).Length == 2)
                {
                    carpeta = command[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    origen = carpeta[0];
                    destino = carpeta[1];
                    destinoFile = string.Format("{0}\\{1}", destino, origen.Split("\\")[origen.Split("\\").Length - 1]);
                }
                else
                {
                    Console.WriteLine("Demasiados argumentos");
                    return;
                }
                if(File.Exists(origen) && Directory.Exists(destino))
                {
                    try
                    {
                        File.Move(origen, destinoFile);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("No existe el archivo o el directorio");
                }
            }
            else
            {
                Console.WriteLine("Muy pocos argumentos para el comando \"move \"");
            }
        }

        //History: muestra la lista de comandos ejecutados previamente, no recibe argumentos.
        public static void history(string [] command, List<string> historia)
        {
            if (command.Length == 1)
            {
                foreach (string comando in historia)
                {
                    Console.WriteLine(comando);
                }
                Console.WriteLine(command[0]);
            }
            else { Console.WriteLine("Demasiados argumentos para el comando \"history\""); }
        }

        //Cls: Limpia la pantalla, no recibe argumentos.
        public static void cls(string[] command)
        {
            if (command.Length == 1)
                Console.Clear();
            else
                Console.WriteLine("Demasiados argumentos para el comando clear");
        }

    }
}