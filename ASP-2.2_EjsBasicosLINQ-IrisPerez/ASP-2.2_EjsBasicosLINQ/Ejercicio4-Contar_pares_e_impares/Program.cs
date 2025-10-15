using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int> { 2, 4, 4, 6, 8, 2, 10 };

        Console.WriteLine("Lista ejercicio anterior:");

        // Cuento cuantos números pares e impares hay y muestro ambos resultados
        lista.GroupBy(num => num % 2 == 0 ? "Pares" : "Impares") // Agrupo los números en pares e impares
             .ToList().ForEach(grupo => Console.WriteLine($"{grupo.Key}: {grupo.Count()}")); // Por cada grupo, muestro su nombre o clave (Key) y el número de elementos (Count())


        // (La lista del ejercico anterior solo contiene números pares)
        // Voy a probar con una lista que contenga números pares e impares
        Console.WriteLine("\nLista inventada de prueba:");

        List<int> listaInventada = new List<int> { 1, 3, 7, 4, 10, 11, 14, 15, 20 };

        // Cuento cuantos números pares e impares hay y muestro ambos resultados
        listaInventada.GroupBy(num => num % 2 == 0 ? "Pares" : "Impares")
             .ToList().ForEach(grupo => Console.WriteLine($"{grupo.Key}: {grupo.Count()}")); 
    }
}