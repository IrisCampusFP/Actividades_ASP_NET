using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nombres = new List<string> { "Ana", "Luis", "Marta" };

        // Creo una lista de objetos anónimos con las propiedades 'Nombre' y 'Longitud' (cantidad de letras del nombre)
        var listaObjetosAnonimos = nombres
            .Select(nombre => new { Nombre = nombre, Longitud = nombre.Length }) // Por cada nombre de la lista nombres, creo un objeto con las propiedades Nombre y Longitud
            .ToList(); // Convierto el resultado en una lista

        // Muestro las propiedades de todos los objetos de la lista uno a uno
        listaObjetosAnonimos.ForEach(objeto => Console.WriteLine($"Nombre: {objeto.Nombre}, Longitud: {objeto.Longitud}"));
    }
}