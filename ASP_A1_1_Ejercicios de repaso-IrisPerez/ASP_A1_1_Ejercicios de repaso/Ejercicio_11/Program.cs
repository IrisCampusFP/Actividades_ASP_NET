using System;

class Program
{
    static void Main(string[] args)
    {
        ProductoDetallado producto1 = new ProductoDetallado("Portátil", "Ordenador portátil", 800.0);
        producto1["color"] = "Gris";
        producto1["batería"] = "6 horas";

        ProductoDetallado producto2 = new ProductoDetallado("Teclado", "Teclado mecánico", 45.0);
        producto2["color"] = "Blanco";
        producto2["teclas"] = "102";

        ProductoDetallado producto3 = new ProductoDetallado("Auriculares", "Auriculares Bluetooth", 60.0);
        producto3["color"] = "Azul";
        producto3["autonomía"] = "20 horas";

        producto1.Datos();
        producto2.Datos();
        producto3.Datos();
    }
}