using System.Text.Json.Serialization;

namespace ScreenSound.Modelos;

class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($@"
        Artista: {Artista},
        Música: {Nome},
        Duração em segundos: {Duracao / 1000},
        Gênero musical: {Genero}
        Ano de lançamento: {Ano};
        "
        );
    }
}
