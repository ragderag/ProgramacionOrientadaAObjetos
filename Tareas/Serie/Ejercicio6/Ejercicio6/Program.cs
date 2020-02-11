using System;

namespace Ejercicio6
{
    class Program
    {
        //Método Main del programa en donde se realizan las pruebas con dos cuentas
        //La primera se inicializa con $1000 y la segunda con $2000
        //A continuación se realiza un retiro de 1500 a cada cuenta
        //Después se le intenta realizar un retiro negativo de 1500
        //A continuación se le deposita $500 a cada cuenta y después
        //Se deposita -$500
        //Al final se muestra la información de cada cuenta.
        static void Main(string[] args)
        {
            Console.WriteLine("Cuenta Bancaria");
            Console.WriteLine("Creación de las cuentas");
            CuentaBancaria cuenta1 = new CuentaBancaria("Edgar Hernández Vásquez", 1000);
            CuentaBancaria cuenta2 = new CuentaBancaria("Luis Ayala Sanjuan", 2000);
            Console.WriteLine();

            Console.WriteLine("Retiro de $1500");
            cuenta1.Retiro(1500);
            cuenta2.Retiro(1500);
            Console.WriteLine();

            Console.WriteLine("Retiro de -$1500");
            cuenta1.Retiro(-1500);
            cuenta2.Retiro(-1500);
            Console.WriteLine();

            Console.WriteLine("Depósito de $500");
            cuenta1.Deposito(500);
            cuenta2.Deposito(500);
            Console.WriteLine();

            Console.WriteLine("Depósito de -$500");
            cuenta1.Deposito(-500);
            cuenta2.Deposito(-500);
            Console.WriteLine();

            Console.WriteLine("Información de la cuenta");
            cuenta1.MostrarInformacion();
            cuenta2.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
