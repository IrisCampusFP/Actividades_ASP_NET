using System;

class Program
{
    static void Main()
    {
        // Creo un diccionario de países (clave) y sus capitales (valor)
        Dictionary<string, string> paisesCapitales = new Dictionary<string, string>()
        {
            {"España", "Madrid"},
            {"Francia", "París"}
        };

        // Añado más pares clave valor
        paisesCapitales.Add("Italia", "Roma");
        paisesCapitales.Add("Alemania", "Berlín");
        paisesCapitales.Add("Portugal", "Lisboa");

        // Muestro todas las capitales
        foreach (var capital in paisesCapitales.Values)
        {
            Console.WriteLine(capital);
        }
    }
}