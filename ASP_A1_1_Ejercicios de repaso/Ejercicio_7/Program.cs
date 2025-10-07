using System;

class CalcularPromedioTiempos
{
    static void Main(string[] args)
    {
        Console.Write("Introduce el nombre de un corredor: ");
        string nombre = Console.ReadLine();

        Console.Write("Introduce el tiempo de la primera carrera (segundos): ");
        double tiempo1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el tiempo de la segunda carrera (segundos): ");
        double tiempo2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el tiempo de la tercera carrera (segundos): ");
        double tiempo3 = Convert.ToDouble(Console.ReadLine());

        double promedio = CalcularPromedio(tiempo1, tiempo2, tiempo3);

        Console.WriteLine($"Hola, {nombre}, tu tiempo medio es: {promedio} segundos");
    }

    static double CalcularPromedio(double t1, double t2, double t3)
    {
        return (t1 + t2 + t3) / 3;
    }
}