// Desafio 2 — Dada uma lista de livros, retornar os títulos publicados
// após o ano 2000, ordenados alfabeticamente.
using ConsoleApp12.Modelos;

Livro l1 = new("Dom Casmurro", "Machado de Assis", 1899);
Livro l2 = new("Cem Anos de Solidão", "Gabriel García Márquez", 1967);
Livro l3 = new("O Estrangeiro", "Albert Camus", 1942);
Livro l4 = new("Crime e Castigo", "Fiódor Dostoiévski", 1866);
Livro l5 = new("Dom Quixote", "Miguel de Cervantes", 1605);
Livro l6 = new("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 2002);
Livro l7 = new("1984", "George Orwell", 2001);

List<Livro> livros = new List<Livro> { l1, l2, l3, l4, l5, l6, l7 };

var filtragem = livros
    .Where(l => l.Ano > 2000)
    .Select(l => l.Titulo)
    .OrderBy(titulo => titulo)
    .ToList();

foreach (var livro in filtragem)
{
    Console.WriteLine(livro);
}
