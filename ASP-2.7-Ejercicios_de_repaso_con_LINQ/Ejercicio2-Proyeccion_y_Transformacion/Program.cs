using System;

var palabras = new List<string> { "casa", "coche", "árbol", "mesa", "silla" };

// 1. Selecciono solo las palabras con más de 4 letras
var palabrasMasDe4Letras = palabras.Where(p => p.Length > 4);
Console.WriteLine("Palabras con más de 4 letras: " + string.Join(", ", palabrasMasDe4Letras));

// 2. Transformo cada palabra a mayúsculas
var palabrasMayusculas = palabras.Select(p => p.ToUpper());
Console.WriteLine("Palabras en mayúsculas: " + string.Join(", ", palabrasMayusculas));

// 3. Creo un nuevo tipo anónimo con la palabra y su longitud
var palabraYLongitud = palabras.Select(p => new { Palabra = p, Longitud = p.Length });
Console.WriteLine("Palabra y longitud:");
foreach (var elemento in palabraYLongitud) {
    Console.WriteLine("Palabra: " + elemento.Palabra + " | Longitud: " + elemento.Longitud);

}