using System;
using System.Collections.Generic;

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

        // Diccionarios para evitar duplicados y asignar IDs
        Dictionary<string, int> diccionarioEquipos = new Dictionary<string, int>();
        Dictionary<string, int> diccionarioCompeticiones = new Dictionary<string, int>();
        List<Equipo> equipos = new List<Equipo>();
        List<Competicion> competiciones = new List<Competicion>();
        List<Partido> partidos = new List<Partido>();

        int equipoId = 1;
        int competicionId = 1;
        int partidoId = 1;

        foreach (string linea in datos)
        {
            string[] partes = linea.Split(';');
            string nombreEquipo1 = partes[0];
            string nombreEquipo2 = partes[1];
            string resultado = partes[2];
            string nombreCompeticion = partes[3];
            string fechaStr = partes[4];

            // Equipos
            int idEquipo1;
            if (!diccionarioEquipos.TryGetValue(nombreEquipo1, out idEquipo1))
            {
                idEquipo1 = equipoId++;
                diccionarioEquipos[nombreEquipo1] = idEquipo1;
                equipos.Add(new Equipo { Id = idEquipo1, Nombre = nombreEquipo1 });
            }
            int idEquipo2;
            if (!diccionarioEquipos.TryGetValue(nombreEquipo2, out idEquipo2))
            {
                idEquipo2 = equipoId++;
                diccionarioEquipos[nombreEquipo2] = idEquipo2;
                equipos.Add(new Equipo { Id = idEquipo2, Nombre = nombreEquipo2 });
            }

            // Competiciones
            int idCompeticion;
            if (!diccionarioCompeticiones.TryGetValue(nombreCompeticion, out idCompeticion))
            {
                idCompeticion = competicionId++;
                diccionarioCompeticiones[nombreCompeticion] = idCompeticion;
                competiciones.Add(new Competicion { Id = idCompeticion, Nombre = nombreCompeticion });
            }

            // Fecha
            DateOnly fecha = DateOnly.Parse(fechaStr);

            // Partido
            Partido partido = new Partido
            {
                Id = partidoId++,
                Equipo1Id = idEquipo1,
                Equipo2Id = idEquipo2,
                CompeticionId = idCompeticion,
                Resultado = resultado,
                Fecha = fecha
            };
            partidos.Add(partido);
        }


        // Salida por consola:

        Console.WriteLine("Equipos:");
        foreach (Equipo e in equipos)
        {
            Console.WriteLine($"{e.Id}: {e.Nombre}");
        }
        Console.WriteLine();

        Console.WriteLine("Competiciones:");
        foreach (Competicion c in competiciones)
        {
            Console.WriteLine($"{c.Id}: {c.Nombre}");
        }
        Console.WriteLine();

        Console.WriteLine("Partidos:");
        foreach (Partido p in partidos)
        {
            Console.WriteLine($"{p.Id}: Equipo1={p.Equipo1Id}, Equipo2={p.Equipo2Id}, Competicion={p.CompeticionId}, Resultado={p.Resultado}, Fecha={p.Fecha:dd/MM/yyyy}");
        }
    }
}