using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 12, 8, 23, 4, 16, 19, 7, 10, 3 };

        // Ordeno los números de mayor a menor
        var numerosOrdenados = numeros.OrderByDescending(num => num);

        // Multiplico por 2 cada número
        var numerosOrdenadosPor2 = numerosOrdenados.Select(n => n * 2);

        // Muestro los números ordenados de forma descendente y multiplicados por 2
        Console.WriteLine("Números ordenados y multiplicados por 2:");
        foreach (int num in numerosOrdenadosPor2)
        {
            Console.WriteLine(num);
        }
    }
}