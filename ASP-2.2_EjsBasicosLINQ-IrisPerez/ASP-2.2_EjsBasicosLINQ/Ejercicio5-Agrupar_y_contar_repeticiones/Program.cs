using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int> { 1, 2, 2, 3, 3, 3, 4 };

        // Muestro cada número y la cantidad de veces que aparece en la lista
        lista.GroupBy(num => num).ToList().ForEach(num => Console.WriteLine($"Número {num.Key} aparece {num.Count()} veces."));
    }
}