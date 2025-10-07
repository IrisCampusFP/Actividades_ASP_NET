using System;

class EdadEnMeses
{
    static void Main(string[] args)
    {
        Console.Write("Introduce tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        int edadMeses = edad * 12;

        Console.WriteLine($"Has vivido {edadMeses} meses.");
    }
}