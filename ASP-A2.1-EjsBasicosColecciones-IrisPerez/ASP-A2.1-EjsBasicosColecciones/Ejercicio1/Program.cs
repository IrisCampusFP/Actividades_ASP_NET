using System;

class Program
{
    static void Main()
    {
        // Creo una lista de enteros
        List<int> numeros = new List<int>();

        // Agrego los números del 1 al 5
        for (int i = 1; i <= 5; i++)
        {
            numeros.Add(i);
        }

        // Mostrar todos los elementos de la listapor consola
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}