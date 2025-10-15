using System;

class Program
{
    static void Main()
    {
        // Creo el diccionario de alumnos y edades
        var alumnos = new Dictionary<string, int>
        {
            { "Ana", 25 },
            { "Luis", 30 }
        };

        Console.Write("Ingresa nombre del alumno: ");
        string nombre = Console.ReadLine();

        // Busco el nombre en el diccionario de forma segura y muestro la edad del alumno
        if (alumnos.TryGetValue(nombre, out int edad))
        {
            Console.WriteLine("Edad: " + edad);
        }
        else
        {
            Console.WriteLine("Alumno no encontrado");
        }
    }
}