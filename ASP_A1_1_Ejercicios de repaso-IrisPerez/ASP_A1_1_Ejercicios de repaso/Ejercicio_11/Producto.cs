using System;

class Producto
{
    //private string _nombre = "";
    private double _precio = 0;

    private string _descripcion = "";

    private Dictionary<string, string> _características = new Dictionary<string, string>();

    public string Nombre { set; get; }

    public virtual double Precio
    {
    set { if (value < 0) _precio = 0;
    else _precio = value;}
    get { return _precio; }
    }

    public string Descripcion { set; get; }

        

    public Producto(string nombre, string descripcion, double precio)
    {
        Nombre = nombre;
        Precio = precio;
        Descripcion = descripcion;
    }

    public virtual void Datos()
    {
        Console.WriteLine($"Producto: {Nombre}");
        Console.WriteLine($"Precio: {Precio} euros\n");
        Console.WriteLine($"Descripción: {Descripcion}");
    }
}

