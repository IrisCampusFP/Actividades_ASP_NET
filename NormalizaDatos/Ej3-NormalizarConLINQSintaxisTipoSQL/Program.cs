using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> datos = new List<string> {
            "Real Madrid;Barcelona;2-1;Liga;2025-10-12",
            "Atlético de Madrid;Sevilla;1-0;Liga;2025-10-13",
            "Barcelona;Valencia;3-2;Copa del Rey;2025-10-14",
            "Sevilla;Real Madrid;0-2;Liga;2025-10-15",
            "Valencia;Atlético de Madrid;1-1;Copa del Rey;2025-10-16",
            "Real Madrid;Atlético de Madrid;2-2;Liga;2025-10-17",
            "Barcelona;Sevilla;4-0;Liga;2025-10-18",
            "Valencia;Real Madrid;0-1;Copa del Rey;2025-10-19",
            "Atlético de Madrid;Barcelona;1-3;Liga;2025-10-20",
            "Sevilla;Valencia;2-2;Copa del Rey;2025-10-21"
        };

        // Equipos
        var equiposNombres = (from linea in datos let partes = linea.Split(';')
                              from nombre in new[] { partes[0], partes[1] } 
                              select nombre).Distinct().ToList();

        var equipos = (from nombre in equiposNombres.Select((n, i) => new { n, i })
                       select new Equipo { Id = nombre.i + 1, Nombre = nombre.n }).ToList();

        // Competiciones
        var competicionesNombres =(from linea in datos let partes = linea.Split(';') 
                                   select partes[3]).Distinct().ToList();

        var competiciones = (from nombre in competicionesNombres.Select((n, i) => new { n, i })
             select new Competicion { Id = nombre.i + 1, Nombre = nombre.n }).ToList();

        // Diccionarios
        var equiposDict = (from eq in equipos select eq).ToDictionary(e => e.Nombre!, e => e.Id);
        var competicionesDict = (from c in competiciones select c).ToDictionary(c => c.Nombre!, c => c.Id);

        // Partidos
        var partidos = (from tuple in datos.Select((linea, idx) => new { linea, idx })
                        let partes = tuple.linea.Split(';') select new Partido
                        {
                            Id = tuple.idx + 1,
                            Equipo1Id = equiposDict[partes[0]],
                            Equipo2Id = equiposDict[partes[1]],
                            CompeticionId = competicionesDict[partes[3]],
                            Resultado = partes[2],
                            Fecha = DateOnly.Parse(partes[4])
                        }).ToList();

        
        // Salida por consola: 

        Console.WriteLine("Equipos:");
        foreach (Equipo eq in equipos)
        {
            Console.WriteLine($"{eq.Id}: {eq.Nombre}");
        }

        Console.WriteLine("\nCompeticiones:");
        foreach (Competicion c in competiciones)
        {
            Console.WriteLine($"{c.Id}: {c.Nombre}");

        }

        Console.WriteLine("\nPartidos:");
        foreach (Partido p in partidos)
        {
            Console.WriteLine($"{p.Id}: Equipo1={p.Equipo1Id}, Equipo2={p.Equipo2Id}, Competicion={p.CompeticionId}, Resultado={p.Resultado}, Fecha={p.Fecha:dd/MM/yyyy}");
        }
    }
}