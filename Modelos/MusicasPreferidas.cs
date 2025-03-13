using System.Text.Json;

namespace ScreenSound.Modelos;

class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; set; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = [];
    }

    public void AdicionarMusicaFavorita(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas de {Nome}:");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            musica.ExibirDetalhesMusica();
        }
    }

    public void GerarArquivoJSON()
    {
        string json = JsonSerializer.Serialize(
            new { nome = Nome, musicas = ListaDeMusicasFavoritas }
        );
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine(
            $"Arquivo {nomeDoArquivo} criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}"
        );
    }
}
