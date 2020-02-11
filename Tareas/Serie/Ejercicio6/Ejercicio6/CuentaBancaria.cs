using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    //Clase CuentaBancaria que se encarga de hacer los 
    //retiros, depósitos, y mostrar la información
    class CuentaBancaria
    {
        /*Declaración de variables. nombre y saldo*/
        string nombre;
        float saldo = 0;

        //Constructor de la clase. Recibe el nombre y el saldo de la cuenta.
        //y muestra la información de la cuenta recién creada.
        public CuentaBancaria(string nombre, float saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
            MostrarInformacion();
        }


        //Getter y Setters para nombre y saldo con la restricción de que el saldo no puede ser negativo.
        public string Nombre { get; set; }

        public float Saldo {
            get
            {
                return saldo;
            }
            set 
            { 
                if (value >=0)
                {
                    saldo = value;
                }
            }
        }

        //Método que muestra la información de la cuenta.
        public void MostrarInformacion()
        {
            Console.WriteLine("Cuenta: {0} Saldo: {1:C}", Nombre, Saldo);
        }

        //Método que realiza el depósito a la cuenta, verifica que el saldo no sea negativo y muestra la información de la cuenta.
        public void Deposito(float deposito)
        {
            if (deposito >=0)
            {
                Saldo += deposito;
            }
            else
            {
                Console.WriteLine("{0} no se puede depositar saldo negativo", Nombre);
            }
            MostrarInformacion();
        }

        //Método que realiza el retiro de dinero de la cuenta. Verifica que
        //no se ingrese una cantidad negativa y que se dispongan de los fondos suficientes.
        //Al final muestra la información.
        public void Retiro(float retiro)
        {
            if (retiro > Saldo)
            {
                Console.WriteLine("{0} no dispones de los fondos suficientes", Nombre);
            }
            else if (retiro < 0)
            {
                Console.WriteLine("{0} no se puede retirar saldo negativo", Nombre);
            }
            else
            {
                Saldo -= retiro;
            }
            MostrarInformacion();
        }

    }
}
