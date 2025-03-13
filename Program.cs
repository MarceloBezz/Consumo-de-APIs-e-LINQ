using System.Text.Json;
using ScreenSound.Modelos;
using ScreenSound.Filtros;

using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync(
            "https://guilhermeonrails.github.io/api-csharp-songs/songs.json"
        );
        // Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // musicas[207].ExibirDetalhesMusica();
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Taylor Swift");
        // LinqFilter.FiltrarMusicasPorAno(musicas, "2006");

        var musicasPreferidasMarcelo = new MusicasPreferidas("Marcelo");
        musicasPreferidasMarcelo.AdicionarMusicaFavorita(musicas[9]);
        musicasPreferidasMarcelo.AdicionarMusicaFavorita(musicas[4]);
        musicasPreferidasMarcelo.AdicionarMusicaFavorita(musicas[12]);
        musicasPreferidasMarcelo.AdicionarMusicaFavorita(musicas[7]);
        musicasPreferidasMarcelo.AdicionarMusicaFavorita(musicas[5]);
        // musicasPreferidasMarcelo.ExibirMusicasFavoritas();

        var musicasPreferidasFulano = new MusicasPreferidas("Fulano");
        musicasPreferidasFulano.AdicionarMusicaFavorita(musicas[200]);
        musicasPreferidasFulano.AdicionarMusicaFavorita(musicas[428]);
        musicasPreferidasFulano.AdicionarMusicaFavorita(musicas[13]);
        musicasPreferidasFulano.AdicionarMusicaFavorita(musicas[47]);
        musicasPreferidasFulano.AdicionarMusicaFavorita(musicas[205]);
        // musicasPreferidasFulano.ExibirMusicasFavoritas();

        // musicasPreferidasMarcelo.GerarArquivoJSON();
        // musicasPreferidasFulano.GerarArquivoJSON();

        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C#");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
