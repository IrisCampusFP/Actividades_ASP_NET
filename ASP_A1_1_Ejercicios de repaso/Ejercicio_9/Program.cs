using System;
class Producto
{
    public string _nombre;
    public string _descripcion;
    public double _precio;

    public Producto(string nombre, string descripcion, double precio)
    {
        _nombre = nombre;
        _descripcion = descripcion;
        _precio = precio;
    }

    public Producto(string nombre, double precio)
    {
        _nombre = nombre;
        _precio = precio;
    }

    public void Datos()
    {
        Console.WriteLine($"Producto: {_nombre}");
        Console.WriteLine($"Descripción: {_descripcion}");
        Console.WriteLine($"Precio: {_precio} euros\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Producto[] productos = new Producto[3];
        double total = 0;

        for (int i = 0; i < productos.Length; i++)
        {
            Console.Write($"Introduce el nombre del producto {i + 1}: ");
            string nombre = Console.ReadLine();

            Console.Write("Introduce el precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            productos[i] = new Producto(nombre, precio);
            total += precio;
            Console.WriteLine();
        }

        Console.WriteLine("Resumen de la compra:");
        foreach (var producto in productos)
        {
            producto.Datos();
        }
        Console.WriteLine($"Total de la compra: {total} euros");
    }
}