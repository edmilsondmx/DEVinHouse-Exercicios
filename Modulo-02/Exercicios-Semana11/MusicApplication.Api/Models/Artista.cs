namespace MusicApplication.Api.Models;

public class Artista
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string NomeArtistico { get; set; }
    public string PaisOrigem { get; set; }

    public List<Musica> Musicas { get; set; }
    public List<Album> Albuns { get; set; }
}
