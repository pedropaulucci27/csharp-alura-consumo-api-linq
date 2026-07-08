using System.Text.Json;
using System.Text.Json.Serialization;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta)!;
        foreach (var carro in carros)
        {
            carro.ExibirInformacoes();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

internal class Carro
{
    [JsonPropertyName("make")]
    public string? Marca { get; set; }

    [JsonPropertyName("model")]
    public string? Modelo { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("color")]
    public string? Cor { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Cor: {Cor}");
    }
}
