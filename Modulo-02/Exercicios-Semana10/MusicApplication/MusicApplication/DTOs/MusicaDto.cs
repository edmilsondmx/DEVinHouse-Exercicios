using System.ComponentModel.DataAnnotations;

namespace MusicApplication.DTOs;

public class MusicaDto
{
    [Required(ErrorMessage = "O nome da Musica é obrigatório.")]
    [StringLength(40)]
    public string Nome { get; set; }
    public double Duracao { get; set; }
    [Required(ErrorMessage = "O id do artista é obrigatório.")]
    [Range(1, int.MaxValue, ErrorMessage = "O id do artista preisa ser válido!")]
    public int ArtistaId { get; set; }
    public int AlbumId { get; set; }
    public int PlaylistId { get; set; }
}
