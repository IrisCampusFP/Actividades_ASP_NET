using System;

class Program
{
    static void Main()
    {
        // Creo un diccionario de productos y precios
        var productos = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            { "Laptop", 1500 },
            { "Mouse", 25 },
            { "Teclado", 45 }
        };

        Console.Write("Ingresa producto: ");
        string producto = Console.ReadLine();

        // Busco el producto en el diccionario de forma segura y muestro el precio
        if (!productos.TryGetValue(producto, out double precio))
        {
            Console.WriteLine("Producto no encontrado");
            return;
        }

        Console.Write("Ingresa cantidad: ");
        try
        {
            int cantidad = int.Parse(Console.ReadLine());
            double total = precio * cantidad;
            Console.WriteLine($"Total: {total}");
        }
        catch (Exception e) {
            Console.WriteLine("Cantidad no válida");
        }
    }
}