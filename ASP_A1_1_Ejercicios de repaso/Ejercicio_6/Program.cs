using System;

class NumeroParOImpar
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"El número {num} es par.");
        }
        else
        {
            Console.WriteLine($"El número {num} es impar.");
        }
    }
}