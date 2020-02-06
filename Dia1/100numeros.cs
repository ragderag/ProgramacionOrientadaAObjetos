
using System;

class Imprime100Numeros 
{
	public static int imprime(int num)
	{
		if(num == 100)
		{
			Console.WriteLine(num);
			return 1;
		}
		Console.WriteLine(num);
		return imprime(num+1);
	}


	static void Main()
	{
		int imprime = Imprime100Numeros.imprime(1);
		Console.ReadKey(true);
	}
}