using System.Text.Json;
using ScreenSound.Modelos;
using ScreenSound.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/alura-cursos/spotify-imersao/main/Spotify-2023.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;

        Console.WriteLine($"Total de músicas: {musicas.Count}");

        var musicasPor2023 = LinqFilter.FiltrarPorAno(musicas, 2023);
        Console.WriteLine($"\nMúsicas de 2023: {musicasPor2023.Count}");

        var ordenadas = LinqOrder.OrdenarPorPopularidade(musicas);
        Console.WriteLine("\nTop 5 mais populares:");
        foreach (var musica in ordenadas.Take(5))
        {
            musica.ExibirInformacoes();
            Console.WriteLine();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}
