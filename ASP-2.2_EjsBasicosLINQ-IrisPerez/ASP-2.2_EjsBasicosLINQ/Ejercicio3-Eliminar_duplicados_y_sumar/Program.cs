using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int> { 2, 4, 4, 6, 8, 2, 10 };

        // Elimino los números duplicados usando Distinct
        var listaSinDuplicados = lista.Distinct();

        // Muestro la lista resultante tras eliminar los duplicados
        Console.WriteLine("Lista sin números duplicados:");
        foreach (int num in listaSinDuplicados)
        {
            Console.WriteLine(num);
        }

        // Sumo todos los números únicos
        int sumaNumerosUnicos = listaSinDuplicados.Sum();

        // Muestro el resultado de la suma de todos los números únicos
        Console.WriteLine("Suma de los números únicos: " + sumaNumerosUnicos);
        

        
    }
}