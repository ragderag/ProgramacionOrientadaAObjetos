using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el número de alumnos a calificar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Alumno [] alumnos = new Alumno[numero];
            
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Datos del alumno {0}",i+1);
                alumnos[i] = new Alumno();
                Console.Write("Nombre: ");
                alumnos[i].Nombre=Console.ReadLine();
                Console.Write("Apellido Paterno: ");
                alumnos[i].ApellidoPaterno = Console.ReadLine();
                Console.Write("Apellido Materno: ");
                alumnos[i].ApellidoMaterno = Console.ReadLine();
                
                Console.Write("Calificación del proyecto: ");
                alumnos[i].CalificacionProyecto = Convert.ToDouble(Console.ReadLine());
                Console.Write("Numero de tareas: ");
                alumnos[i].Tareas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Numero de participaciones: ");
                alumnos[i].Participaciones = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            foreach (Alumno alu in alumnos)
            {
                Calculadora.promedioFinal(alu);
                Console.WriteLine("Alumno {0} {1} {2} tiene calificación final de {3}", alu.Nombre, alu.ApellidoPaterno, alu.ApellidoMaterno, alu.CalificacionFinal);
            }

            Console.ReadKey();
        }
    }
    public static class Calculadora
    {
        public static void promedioFinal(Alumno alum)
        {
            alum.CalificacionFinal = alum.CalificacionProyecto * 0.60 + (Convert.ToDouble(alum.Tareas) * 4/5) ;
            if (alum.Participaciones >= 5) { alum.CalificacionFinal += 0.8; }
        }
    }
}
