using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ejercicio5
{
    //Clase Agenda que tiene los métodos "agregar", "eliminar", "mostrar". es el diccionario en donde se guardan
    //los nombres y telefonos de los contactos
    class Agenda
    {
        Dictionary<string, string> agenda = new Dictionary<string, string>();

        //Método Agregar para agregar el nombre y teléfono al diccionario "agenda"
        public void Agregar(string nombre, string telefono)
        {
            nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre);
            try
            {
                agenda.Add(nombre, telefono);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Un usuario con el nombre {0} ya existe", nombre);
            }

        }

        //Método Eliminar para eliminar un contacto del diccionario "agenda" por el nombre
        public void Eliminar(string nombre)
        {
            nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre);
            if (agenda.ContainsKey(nombre))
            {
                agenda.Remove(nombre);
                Console.WriteLine("El contacto {0} se eliminó exitosamente.",nombre);
            }
            else
            {
                Console.WriteLine("El contacto {0} no existe",nombre);
            }
        }
        
        //Método Mostrar para mostrar todos los contactos que se encuentran en el diccionario "agenda"
        public void Mostrar()
        {
            if (agenda.Count == 0)
            {
                Console.WriteLine("No hay contactos que mostrar");
                return;
            }
            foreach (KeyValuePair<string, string> kvp in agenda)
            {
                Console.WriteLine("Nombre: {0}\tTeléfono: {1}",kvp.Key, kvp.Value);
            }
        }
        
        //Constructor.
        public Agenda() { }

    }
}
