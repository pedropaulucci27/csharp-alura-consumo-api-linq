using ScreenSound4.Filtros;
using ScreenSound4.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        // Exemplos de uso dos filtros e ordenações desenvolvidos ao longo da aula:
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        // musicas[0].ExibirDetalhesDaMusica();

        LinqFilter.FiltrarMusicasDoSustenido(musicas);

        var musicasPreferidasDoPedro = new MusicasPreferidas("Pedro");
        musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[0]);
        musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[100]);
        musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[1000]);
        musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[436]);
        musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[984]);

        musicasPreferidasDoPedro.ExibirMusicasFavoritas();
        musicasPreferidasDoPedro.GerarArquivoJson();
        musicasPreferidasDoPedro.GerarDocumentoTXTComAsMusicasFavoritas();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }
}
