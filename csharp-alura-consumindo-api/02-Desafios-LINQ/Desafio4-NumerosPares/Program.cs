// Desafio 4 — Dada uma lista de inteiros, retornar apenas os números pares.
List<int> inteiros = new List<int>() { 1, 3, 4, 55, 6, 10 };

var pares = inteiros.Where(p => p % 2 == 0).ToList();

foreach (var par in pares)
{
    Console.WriteLine(par);
}
