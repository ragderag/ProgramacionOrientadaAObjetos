using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    //clase Auto que tiene 4 métodos. Avanzar, Detener, Encender y Apagar.
    class Auto
    {
        //Declaración de los atributos de tipo privadas.
        private string marca, subMarca, color;
        private bool onOff=false;
        private int modelo;


        //Getters y Setters de todos los atributos de la clase.
        public string Marca 
        {
            get { return marca; }
            set { marca = value; }
        }
        public string SubMarca 
        { 
            get { return subMarca; }
            set { subMarca = value; }
        }
        public string Color 
        {
            get { return color; }
            set { color = value; }
        }
        public bool OnOff 
        {
            get { return onOff; }
            set { onOff = value; }
        }
        public int Modelo 
        {
            get { return modelo; }
            set { modelo = value; }
        }

        //Constructor de la clase. Recibe la marca y el modelo del auto
        public Auto(string marca, int modelo) 
        {
            Marca = marca;
            Modelo = modelo;
        }

        //Sobrecarga del constructor. Recibe la marca, sub marca, color y modelo del auto.
        public Auto(string marca, string subMarca, string color, int modelo)
        {
            Marca = marca;
            SubMarca = subMarca;
            Color = color;
            Modelo = modelo;
        }

        //Método Avanzar que indica que el auto está avanzanda sólo si está encendido, sino indica que está apagado
        public void Avanzar()
        {
            if (OnOff)
            {
                Console.WriteLine("El auto {0} {1} está avanzando...",Marca,SubMarca);
            }
            else
            {
                Console.WriteLine("No puedo avanzar, estoy apagado. {0} {1}",Marca,SubMarca);
            }
        }

        //Método que detiene el auto
        public void Detener()
        {
            Console.WriteLine("El auto {0} {1} está detenido",Marca,SubMarca);
        }

        //Método que enciende el auto
        public void Encender()
        {
            OnOff = true;
            Console.WriteLine("El auto {0} {1} se encendió", Marca, SubMarca);
        }

        //Método que apaga el auto.
        public void Apagar()
        {
            OnOff = false;
            Console.WriteLine("El auto {0} {1} se apagó", Marca, SubMarca);
        }
    }
}
