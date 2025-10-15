using System;

class Program
{
    static void Main()
    {
        int num;
         
        Console.Write("Ingresa un número: ");
        string entrada = Console.ReadLine();

        try
        {
            // Convierto el número a entero con TryParse, si no se puede se muestra "Valor no válido"
            if (!int.TryParse(entrada, out num))
            {
                Console.WriteLine("Valor no válido");
            }
            else if (num < 0)
            {
                // Lanzo una excepción personalizada si es negativo
                throw new Exception("El número no puede ser negativo");
            }
            else
            {
                // Si es válido y positivo o cero, salir del ciclo
                Console.WriteLine("Número aceptado: " + num);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

    }
}