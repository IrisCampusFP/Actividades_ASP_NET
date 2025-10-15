using System;

class Program
{
    // Declaro un delegado que recibe dos enteros y devuelve uno
    delegate int Operacion(int a, int b);

    // Creo un método que suma dos números
    static int Sumar(int x, int y)
    {
        return x + y;
    }

    static void Main()
    {
        // Asigno el método al delegado
        Operacion miOperacion = Sumar;

        // Uso el delegado para sumar 3 y 4
        Console.WriteLine("3 + 4 = " + miOperacion(3, 4));
    }
}