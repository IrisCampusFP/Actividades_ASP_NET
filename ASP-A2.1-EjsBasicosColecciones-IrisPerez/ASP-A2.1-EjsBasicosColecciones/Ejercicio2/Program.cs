using System;

class Program
{
    static void Main()
    {
        // Creo una cola de cadenas
        Queue<string> nombres = new Queue<string>();

        // Agrego tres nombres
        nombres.Enqueue("Mario");
        nombres.Enqueue("Ian");
        nombres.Enqueue("Rafa");

        // Elimino y muestro cada nombre hasta que la cola esté vacía
        while (nombres.Count > 0)
        {
            string nombre = nombres.Dequeue();
            Console.WriteLine(nombre);
        }

        // Muestro que la cola está vacía
        Console.WriteLine($"\nNombres restantes en la cola: {nombres.Count}.");
    }
}