using System;

class SaludoPersonalizado
{
    static void Main(string[] args)
    {
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine($"Hola, {nombre}, bienvenido/a al programa.");
    }
}