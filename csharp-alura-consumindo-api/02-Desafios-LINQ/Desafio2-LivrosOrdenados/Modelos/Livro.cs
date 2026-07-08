namespace ConsoleApp12.Modelos;

internal class Livro
{
    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }

    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
}
