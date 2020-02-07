using System;

class Program
{
	static void Main()
	{
		int[] list = {34,72,13,44,25,30,10};
		int[] temp = new int[list.Length];

		//Genera una copia del arreglo original

		Array.Copy(list,temp,list.Length);

		Console.WriteLine("Arreglo Original: ");

		//Invierte el arreglo
		Console.WriteLine("Arreglo Invertido: ");
		Array.Reverse(temp);
		MostrarArreglo(list);

		//Ordena el arreglo
		Array.Sort(list);
		Console.WriteLine("Arreglo Ordenado: ");
		MostrarArreglo(list);

		Console.WriteLine("Indice del número 44 "+Array.IndexOf(temp,44));
		Console.ReadKey();

	}

	static void MostrarArreglo(int[] arreglo)
	{
		foreach(int i in arreglo)
		{
			Console.Write(i+" ");
		}
		Console.WriteLine();
	}

}