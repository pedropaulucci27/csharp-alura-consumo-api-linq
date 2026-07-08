using System.Text.Json.Serialization;

namespace ScreenSound.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int DuracaoMs { get; set; }

    [JsonPropertyName("year")]
    public int Ano { get; set; }

    [JsonPropertyName("bpm")]
    public int Bpm { get; set; }

    [JsonPropertyName("energy")]
    public int Energia { get; set; }

    [JsonPropertyName("danceability")]
    public int Danceability { get; set; }

    [JsonPropertyName("loudness..dB.")]
    public double Loudness { get; set; }

    [JsonPropertyName("liveness")]
    public int Liveness { get; set; }

    [JsonPropertyName("valence.")]
    public double Valence { get; set; }

    [JsonPropertyName("acousticness..")]
    public double Acousticness { get; set; }

    [JsonPropertyName("speechiness.")]
    public double Speechiness { get; set; }

    [JsonPropertyName("popularity")]
    public int Popularidade { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Popularidade: {Popularidade}");
        Console.WriteLine($"BPM: {Bpm}");
        Console.WriteLine($"Energia: {Energia}");
    }
}
