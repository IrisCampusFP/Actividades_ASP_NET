using System;

var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


// 1. Filtro los números mayores a 5 usando sintaxis de consulta
var numerosMayoresA5 = from n in numeros where n > 5 select n;
Console.WriteLine("Números mayores a 5 (sintaxis consulta): " + string.Join(", ", numerosMayoresA5));

// (Hago lo mismo usando la sintaxis de método)
var numerosMayoresA5metodo = numeros.Where(n => n > 5);
Console.WriteLine("Números mayores a 5 (sintaxis método): " + string.Join(", ", numerosMayoresA5metodo));

// 2. Filtro los números pares usando sintaxis de método
var pares = numeros.Where(n => n % 2 == 0);
Console.WriteLine("Números múltiplos de 3 (sintaxis método): " + string.Join(", ", pares));

// 3. Filtro los números múltiplos de 3 usando sintaxis de método
var multiplosDe3 = numeros.Where(n => n % 3 == 0);
Console.WriteLine("Números múltiplos de 3 (sintaxis método): " + string.Join(", ", multiplosDe3));
