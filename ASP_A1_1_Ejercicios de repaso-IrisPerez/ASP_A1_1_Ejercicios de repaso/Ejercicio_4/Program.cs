using System;

class MayorDeDosNumeros
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce otro número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"{num1} es mayor que {num2}");
        }
        else if (num2 > num1)
        {
            Console.WriteLine($"{num2} es mayor que {num1}");
        }
        else
        {
            Console.WriteLine("Los números son iguales");
        }
    }
}