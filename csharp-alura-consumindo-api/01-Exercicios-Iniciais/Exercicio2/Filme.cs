using System.Text.Json;
using System.Text.Json.Serialization;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
        foreach (var filme in filmes)
        {
            filme.ExibirInformacoes();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

internal class Filme
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("rank")]
    public string? Rank { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Lugar no rank: {Rank}");
        Console.WriteLine($"Ano de lançamento: {Ano}");
        Console.WriteLine($"Título do filme: {Titulo}");
    }
}
