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

    public void Datos()
    {
        Console.WriteLine($"Nombre: {_nombre}");
        Console.WriteLine($"Descripción: {_descripcion}");
        Console.WriteLine($"Precio: {_precio} euros\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Producto producto1 = new Producto("Portátil", "Ordenador portátil de 15 pulgadas", 799.99);
        Producto producto2 = new Producto("Ratón", "Ratón inalámbrico ergonómico", 24.50);
        Producto producto3 = new Producto("Monitor", "Monitor Full HD de 24 pulgadas", 159.90);

        Console.WriteLine("Datos del primer producto: ");
        producto1.Datos();
        Console.WriteLine("Datos del segundo producto: ");
        producto2.Datos();
        Console.WriteLine("Datos del tercer producto: ");
        producto3.Datos();
    }
}