using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creo una pila de caracteres
        Stack<char> letras = new Stack<char>();

        // Agrego las letras 'A', 'B' y 'C'
        letras.Push('A');
        letras.Push('B');
        letras.Push('C');

        // Extraigo (pop) y muestro cada letra hasta que la pila esté vacía
        while (letras.Count > 0)
        {
            char letra = letras.Pop();
            Console.WriteLine(letra);
        }

        // Muestro que la pila está vacía
        Console.WriteLine("\nNúmero de letras restantes en la pila: " + letras.Count);
    }
}