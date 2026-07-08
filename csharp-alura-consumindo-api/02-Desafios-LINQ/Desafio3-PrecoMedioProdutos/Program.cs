// Desafio 3 — Dada uma lista de produtos, calcular o preço médio.
using ConsoleApp12.Modelos;

Produto p1 = new("Banana", 10);
Produto p2 = new("Bolsa", 300);
Produto p3 = new("Perfume", 1000);
Produto p4 = new("Teclado", 600);
Produto p5 = new("Caneta", 2);

List<Produto> produtos = new() { p1, p2, p3, p4, p5 };

double precoMedio = produtos.Average(p => p.Preco);
Console.WriteLine(precoMedio);
