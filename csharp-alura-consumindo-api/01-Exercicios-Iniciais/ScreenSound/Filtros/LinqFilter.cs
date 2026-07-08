using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqFilter
{
    public static List<Musica> FiltrarPorAno(List<Musica> musicas, int ano)
    {
        return musicas.Where(m => m.Ano == ano).ToList();
    }

    public static List<Musica> FiltrarPorArtista(List<Musica> musicas, string artista)
    {
        return musicas.Where(m => m.Artista == artista).ToList();
    }

    public static List<Musica> FiltrarPorPopularidade(List<Musica> musicas, int popularidade)
    {
        return musicas.Where(m => m.Popularidade >= popularidade).ToList();
    }
}
