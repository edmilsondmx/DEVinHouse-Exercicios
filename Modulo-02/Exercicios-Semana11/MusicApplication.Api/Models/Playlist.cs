using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Api.Models;

public class Playlist
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nome da Playlist obrigatório.")]
    public string Nome { get; set; }
    public string Estilo { get; set; }
    public List<Musica> Musicas { get; set; } = new ();

    public Playlist(string nome, string estilo)
    {
        Nome = nome;
        Estilo = estilo;

    }


}
