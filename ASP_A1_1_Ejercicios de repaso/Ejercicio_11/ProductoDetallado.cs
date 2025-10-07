using System;
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

    // propiedad indexada
    public string this[string key]
    {
        get { return _caracteristicas[key]; }
        set { _caracteristicas[key] = value; }
    }

    /* sobrescribo el método Datos para que muestre también 
     * las características específicas de los productos */
    public override void Datos()
    {
        Console.WriteLine($"Producto: {Nombre}");
        Console.WriteLine($"Descripción: {Descripcion}");
        Console.WriteLine($"Precio: {Precio} euros");
        Console.WriteLine("Características:");
        foreach (var caracteristica in _caracteristicas)
        {
            Console.WriteLine($"- {caracteristica.Key}: {caracteristica.Value}");
        }
        Console.WriteLine();
    }
}