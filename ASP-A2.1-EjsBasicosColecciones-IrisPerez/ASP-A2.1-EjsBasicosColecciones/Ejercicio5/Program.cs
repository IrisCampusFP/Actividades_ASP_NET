using System;

class Program
{
    static void Main()
    {
        // Creo un conjunto de números enteros y agrego números (algunos duplicados)
        HashSet<int> numeros = new HashSet<int> { 1, 2, 2, 3 };

        // Agrego más números
        numeros.Add(4);
        numeros.Add(4);
        numeros.Add(5);

        // Muestro todos los elementos del conjunto
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        /* RESULTADO: En un conjunto (HashSet)
         * no se agregan números duplicados, 
         * cada elemento es único */
    }
}