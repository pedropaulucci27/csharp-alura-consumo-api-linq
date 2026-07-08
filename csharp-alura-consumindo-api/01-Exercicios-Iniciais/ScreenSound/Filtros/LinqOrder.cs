using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqOrder
{
    public static List<Musica> OrdenarPorAno(List<Musica> musicas)
    {
        return musicas.OrderBy(m => m.Ano).ToList();
    }

    public static List<Musica> OrdenarPorPopularidade(List<Musica> musicas)
    {
        return musicas.OrderByDescending(m => m.Popularidade).ToList();
    }

    public static List<Musica> OrdenarPorBpm(List<Musica> musicas)
    {
        return musicas.OrderByDescending(m => m.Bpm).ToList();
    }
}
