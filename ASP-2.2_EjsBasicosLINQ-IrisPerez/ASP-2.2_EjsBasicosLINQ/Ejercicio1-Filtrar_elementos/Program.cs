using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 12, 8, 23, 4, 16, 19, 7, 10, 3 };

        // Filtro los números mayores que 10 usando LINQ
        var mayoresQueDiez = numeros.Where(num => num > 10);

        // Imprimo los números mayores que 10
        Console.WriteLine("Números mayores que 10: ");
        foreach (int num in mayoresQueDiez)
        {
            Console.WriteLine(num);
        }
    }
}