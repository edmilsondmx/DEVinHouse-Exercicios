using System.ComponentModel.DataAnnotations;

namespace MusicApplication.DTOs;

public class MusicaDto
{
    [Required(ErrorMessage = "O nome da Musica é obrigatório.")]
    [StringLength(40)]
    public string Nome { get; set; }
    public double Duracao { get; set; }
    public int ArtistaId { get; set; }
    public int AlbumId { get; set; }
}
