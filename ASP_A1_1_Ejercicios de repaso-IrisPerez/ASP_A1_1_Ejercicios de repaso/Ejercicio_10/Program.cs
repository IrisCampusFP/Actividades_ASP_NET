using System;
using System.Collections.Generic;

class Producto
{
    private string _nombre;
    private string _descripcion;
    private double _precio;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public string Descripcion
    {
        get { return _descripcion; }
        set { _descripcion = value; }
    }

    public virtual double Precio
    {
        get { return _precio; }
        set { _precio = value; }
    }

    public Producto(string nombre, string descripcion, double precio)
    {
        _nombre = nombre;
        _descripcion = descripcion;
        _precio = precio;
    }

    public virtual void Datos()
    {
        Console.WriteLine($"Producto: {_nombre}");
        Console.WriteLine($"Descripción: {_descripcion}");
        Console.WriteLine($"Precio: {_precio} euros\n");
    }
}

class ProductoDetallado : Producto
{
    private Dictionary<string, string> _caracteristicas = new Dictionary<string, string>();

    public ProductoDetallado(string nombre, string descripcion, double precio)
        : base(nombre, descripcion, precio)
    {
        _caracteristicas = new Dictionary<string, string>();
    }

    public ProductoDetallado(string nombre, string descripcion, double precio, Dictionary<string, string> caracteristicas)
        : base(nombre, descripcion, precio)
    {
        _caracteristicas = caracteristicas;
    }

    public string this[string key]
    {
        get
        {
            if (_caracteristicas.ContainsKey(key))
                return _caracteristicas[key];
            else
                return null;
        }
        set
        {
            _caracteristicas[key] = value;
        }
    }

    public override void Datos()
    {
        Console.WriteLine($"Producto: {Nombre}");
        Console.WriteLine($"Descripción: {Descripcion}");
        Console.WriteLine($"Precio: {Precio} euros");
        Console.WriteLine("Características:");
        foreach (var kvp in _caracteristicas)
        {
            Console.WriteLine($"- {kvp.Key}: {kvp.Value}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ProductoDetallado producto1 = new ProductoDetallado("Portátil", "Ordenador portátil", 800.0);
        producto1["peso"] = "2 Kg";
        producto1["color"] = "Gris";
        producto1["batería"] = "6 horas";

        ProductoDetallado producto2 = new ProductoDetallado("Teclado", "Teclado mecánico", 45.0);
        producto2["peso"] = "900 g";
        producto2["color"] = "Blanco";
        producto2["tipo"] = "Mecánico";

        ProductoDetallado producto3 = new ProductoDetallado("Auriculares", "Auriculares Bluetooth", 60.0);
        producto3["peso"] = "250 g";
        producto3["color"] = "Azul";
        producto3["autonomía"] = "20 horas";

        producto1.Datos();
        producto2.Datos();
        producto3.Datos();
    }
}