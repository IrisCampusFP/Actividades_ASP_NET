using System;

class AprobadoOSuspendido
{
    static void Main(string[] args)
    {
        Console.Write("Introduce una nota: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        if (nota >= 5)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Suspendido");
        }
    }
}