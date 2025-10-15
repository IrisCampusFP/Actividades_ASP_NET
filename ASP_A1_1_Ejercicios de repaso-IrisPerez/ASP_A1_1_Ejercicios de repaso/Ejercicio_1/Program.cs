using System;

class SumaDosNumeros
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce otro número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Suma: " + (num1 + num2));
        Console.WriteLine("Resta: " + (num1 - num2));
        Console.WriteLine("Multiplicación: " + (num1 * num2));

        if (num2 != 0)
            Console.WriteLine("División: " + (num1 / num2));
        else
            Console.WriteLine("División: No se puede dividir por cero");
    }
}