using System.Text.Json;
using System.Text.Json.Serialization;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta)!;
        foreach (var pais in paises)
        {
            pais.ExibirInformacoes();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

internal class Pais
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }

    [JsonPropertyName("capital")]
    public string? Capital { get; set; }

    [JsonPropertyName("area")]
    public string? Area { get; set; }

    [JsonPropertyName("population")]
    public string? Populacao { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"Área: {Area}");
        Console.WriteLine($"População: {Populacao}");
    }
}
