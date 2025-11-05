using System;

public class Producto()
{
    public String? Nombre { get; set; }
    public String? Categoria { get; set; }

    public double Precio { get; set; }
}

public class Programa()
{
    public static void Main(string[] args)
    {
        var productos = new List<Producto>
        {
            new Producto { Nombre = "Laptop", Categoria = "Electrónicos", Precio = 800 },
            new Producto { Nombre = "Mouse", Categoria = "Electrónicos", Precio = 25 },
            new Producto { Nombre = "Silla", Categoria = "Muebles", Precio = 150 },
            new Producto { Nombre = "Mesa", Categoria = "Muebles", Precio = 300 }
        };

        // 1. Agrupo todos los productos por categoría
        var productosAgrupadosPorCategoria = productos.GroupBy(p => p.Categoria);
        Console.WriteLine("Productos agrupados por categoría:");
        
        foreach (var categoria in productosAgrupadosPorCategoria)
        {
            Console.WriteLine("Categoría: " + categoria.Key);
            foreach (var producto in categoria)
            {
                Console.WriteLine("Producto: " + producto.Nombre + " | Precio: " + producto.Precio);
            }
        }

        // 2. Para cada categoría, calculo el precio promedio
        var precioPromedioPorCategoria = productosAgrupadosPorCategoria
            .Select(c => new { Categoria = c.Key, Promedio = c.Average(p => p.Precio) });

        Console.WriteLine("\nPrecio promedio por categoría:");
        foreach (var elemento in precioPromedioPorCategoria)
        {
            Console.WriteLine("Categoría " + elemento.Categoria + " | Precio promedio: " + elemento.Promedio);
        }

        // 3. Encuentro la categoría con el producto más caro
        var productoMasCaro = productos.OrderByDescending(p => p.Precio).First(); // Obtengo el producto más caro
        Console.WriteLine("\nLa categoría con el producto más caro es: " + productoMasCaro.Categoria + " (Producto: " + productoMasCaro.Nombre + " | Precio: " + productoMasCaro.Precio);
    }
}