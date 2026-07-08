using System.Text.Json;
using System.Text.Json.Serialization;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livros = JsonSerializer.Deserialize<List<Livro>>(resposta)!;
        foreach (var livro in livros)
        {
            livro.ExibirInformacoes();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

internal class Livro
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }

    [JsonPropertyName("author")]
    public string? Autor { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Gênero: {Genero}");
    }
}
