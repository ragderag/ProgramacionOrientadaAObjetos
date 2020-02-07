using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    public class Alumno
    {
        string nombre;
        string apellidoPaterno;
        string apellidoMaterno;

        double calificacionProyecto;
        int tareas;
        int participaciones;
        double calificacionFinal;

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string ApellidoPaterno 
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }
        public string ApellidoMaterno 
        { 
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }

        public double CalificacionProyecto
        {
            get { return calificacionProyecto; }
            set
            {
                double temp = Convert.ToDouble(value);
                if (temp >= 0 && temp <= 10) { calificacionProyecto = temp; }
                else { Console.WriteLine("Calificación del proyecto debe ser en el rango (0,10)"); }
                while( temp < 0 || temp > 10)
                {
                    Console.WriteLine("Ingresa una calificación válida en el rango (0,10)");
                    temp=Convert.ToDouble(Console.ReadLine());
                    calificacionProyecto = temp;
                }
            }
        }

        public int Tareas
        {
            get { return tareas; }
            set
            {
                int temp = Convert.ToInt32(value);
                if(temp >= 0 && temp <= 5) { tareas = temp; }
                else { Console.WriteLine("Cantidad de tareas no válida 0 <= tareas <= 5"); }
                while( temp < 0 || temp > 5)
                {
                    Console.WriteLine("Ingresa un numero de tareas en el rango (0,5)");
                    temp = Convert.ToInt32(Console.ReadLine());
                    tareas = temp;
                }
            }
        }

        public int Participaciones
        {
            get { return participaciones; }
            set
            {
                int temp = Convert.ToInt32(value);
                if (temp < 0) 
                {
                    Console.WriteLine("No se pueden asignar participaciones negativas, se asignarán cero participaciones");
                    participaciones = 0;
                }
                else
                {
                    participaciones = value;
                }
            }
        }

        public double CalificacionFinal
        {
            get { return calificacionFinal; }
            set
            {
                if (value >= 10) { calificacionFinal = 10; }
                else if (value <= 5) { calificacionFinal = 5; }
                else { calificacionFinal = value; }
            }
        }

        public Alumno() { }

    }
}
