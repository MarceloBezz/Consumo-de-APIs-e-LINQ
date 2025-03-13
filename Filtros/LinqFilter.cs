using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas
            .Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine($"Artistas do gênero {genero}:");
        foreach (var artista in artistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasPorArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine($"Músicas do(a) artista {artista}:");
        foreach (var musica in musicasPorArtista)
        {
            musica.ExibirDetalhesMusica();
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
    {
        var musicasPorAno = musicas.Where(musica => musica.Ano!.Equals(ano)).ToList();
        Console.WriteLine($"Músicas do ano de {ano}:");
        foreach (var musica in musicasPorAno)
        {
            musica.ExibirDetalhesMusica();
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasPorTonalidade = musicas
            .Where(musica => musica.Tonalidade.Equals(tonalidade))
            .ToList();
        Console.WriteLine($"Músicas da tonalidade {tonalidade}:");
        foreach (var musica in musicasPorTonalidade)
        {
            musica.ExibirDetalhesMusica();
        }
    }
}
