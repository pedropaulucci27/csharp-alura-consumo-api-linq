using System.Text.Json.Serialization;

namespace ScreenSound4.Modelos;

internal class Musica
{
    private List<string> tonalidades = new List<string>() { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string tonalidade
    {
        get
        {
            return tonalidades[Key];
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao / 1000}");
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Tonalidade: {tonalidade}");
    }
}
