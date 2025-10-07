using System;

class Program
{
    static void Main()
    {
        List<string> palabras = new List<string> { "A", "B", "C", "D", "E" };

        Console.Write("Ingresa índice: ");
        string entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int indice))
        {
            Console.WriteLine("Índice no válido");
        }
        else
        {
            string palabra = palabras.ElementAtOrDefault(indice);
            if (palabra == null)
            {
                Console.WriteLine("Índice fuera de rango");
            }
            else
            {
                Console.WriteLine($"Palabra: \"{palabra}\"");
            }
        }
    }
}