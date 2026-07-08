// Desafio 1 — Dada uma lista de números, retornar apenas os elementos únicos.
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 5, 5, 9, 10, 11, 29, 3, 3, 3, 4, 4, 4 };

var numerosFiltrados = numeros.Distinct().ToList();

foreach (int numero in numerosFiltrados)
{
    Console.WriteLine(numero);
}
