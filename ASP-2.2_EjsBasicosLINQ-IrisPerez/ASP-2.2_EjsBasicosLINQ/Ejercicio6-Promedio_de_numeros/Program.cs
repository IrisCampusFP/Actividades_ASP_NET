using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int> { 1, 2, 2, 3, 3, 3, 4 };

        // Filtro la lista dejando solo los números mayores a 1
        var numerosMayoresQue1 = lista.Where(num => num > 1);
        // Calculo el promedio con .Average()
        double promedio = numerosMayoresQue1.Average();

        Console.WriteLine("El promedio de todos los números mayores a 1 en la lista es: " + promedio);
    }
}