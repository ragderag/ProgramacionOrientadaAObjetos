using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio12
{
    //Clase que se encarga de manejar las listas de Productos y Precios.
    //Tiene los métodos de MuestraLista, AniadeProductos y DejarProductos
    class Compras
    {
        //Atributos de la clase. Dos listas, una tipo string para los productos
        //Otra lista de tipo decimal para los precios

        List<string> productos = new List<string>();
        List<decimal> precios = new List<decimal>();
        decimal precio = 0;

        //Get y Set para el atributo precio
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        //Método que muestra la lista y el precio con formato: NumProducto ) Producto Precio
        public void MuestraLista()
        {
            int i = 0;
            foreach (var articulo in productos)
            {
                Console.WriteLine("{0})\t{1}\t{2:C}", i+1, articulo,precios[i]);
                i++;
            }
            Console.WriteLine("Total  a pagar: {0}", Precio);
        }

        //Método que añade productos a las listas. Pide por línea de comandos el nombre
        //del producto y el precio
        public void AniadeProducto()
        {
            Console.Write("Producto: ");
            productos.Add(Console.ReadLine());
            Console.Write("Precio: ");
            decimal temp = Convert.ToDecimal(Console.ReadLine());
            precios.Add(temp);
            Precio += temp;
        }

        //Método que deja productos, imprime en pantalla la lista y te pide el número de indice a dejar
        public void DejarProductos()
        {
            Console.WriteLine("Selecciona el producto que deseas dejar");
            MuestraLista();
            Console.Write("Numero de producto a dejar: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;
            if (indice < productos.Count)
            {
                precio -= precios[indice];
                productos.RemoveAt(indice);
                precios.RemoveAt(indice);
            }
            else
            {
                Console.WriteLine("El indice que ingresaste no existe");
            }
        }

        //Método constructor de la clase
        public Compras()
        {
        }
    }
}
