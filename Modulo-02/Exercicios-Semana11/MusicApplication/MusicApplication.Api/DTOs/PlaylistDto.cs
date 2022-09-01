using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Api.DTOs;

public class PlaylistDto
{
    [Required(ErrorMessage = "Nome da Playlist obrigatório.")]
    public string Nome { get; set; }
    public string Estilo { get; set; }
}
