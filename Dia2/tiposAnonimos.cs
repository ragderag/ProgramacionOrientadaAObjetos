using System;

namespace TiposAnonimos 
{
	class Program 
	{
		static void Main()
		{
			var anonimo = new
			{
				Modelo = "2006",
				Precio = 80000,
				Placas ="MUR7882"
			};

			Console.WriteLine("Datos del objeto anónimo");
			Console.WriteLine(anonimo.Modelo);
			Console.WriteLine(anonimo.Precio);
			Console.WriteLine(anonimo.Placas);
			Console.ReadKey();
		}
	}
}