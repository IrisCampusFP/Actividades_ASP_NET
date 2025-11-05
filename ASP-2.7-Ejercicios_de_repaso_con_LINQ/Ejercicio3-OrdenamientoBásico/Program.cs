using System;

public class Persona()
{
    public String? Nombre { get; set; }
    public int Edad { get; set; }
}

public class Programa()
{
    public static void Main(string[] args)
    {
        var personas = new List<Persona>
        {
            new Persona { Nombre = "Ana", Edad = 25 },
            new Persona { Nombre = "Luis", Edad = 30 },
            new Persona { Nombre = "María", Edad = 22 }
        };

        // 1. Ordeno por edad de forma ascendente
        var personasOrdenadasPorEdad = personas.OrderBy(p => p.Edad);
        Console.WriteLine("Personas ordenadas por edad de forma ascendente:");
        int indice = 1;
        foreach (var persona in personasOrdenadasPorEdad)
        {
            Console.WriteLine(indice + ". Nombre: " + persona.Nombre + " | Edad " + persona.Edad);
            indice++;
        }

        // 2. Ordeno por nombre de forma descendente
        var personasOrdenadasPorNombre = personas.OrderByDescending(p => p.Nombre);
        Console.WriteLine("\nPersonas ordenadas por nombre de forma descendente:");
        foreach (var persona in personasOrdenadasPorNombre)
        {
            Console.WriteLine("Nombre: " + persona.Nombre + " | Edad " + persona.Edad);
        }

        // 3. Ordeno por edad descendente y luego por nombre ascendente
        var personasOrdenadasPorEdadYNombre = personas.OrderByDescending(p => p.Edad).ThenBy(p => p.Nombre);
        Console.WriteLine("\nPersonas ordenadas por nombre de forma descendente:");
        foreach (var persona in personasOrdenadasPorEdadYNombre)
        {
            Console.WriteLine("Nombre: " + persona.Nombre + " | Edad " + persona.Edad);
        }
    }
}
