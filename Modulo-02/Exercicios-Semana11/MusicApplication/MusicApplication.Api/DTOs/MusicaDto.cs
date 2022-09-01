using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Api.DTOs;

public class MusicaDto
{
    [Required (ErrorMessage = "Nome da música obrigatório")]
    public string Nome { get; set; }
    
    public double Duracao { get; set; }

    [Required (ErrorMessage = "Id do artista é obrigatório")]
    [Range (1, int.MaxValue, ErrorMessage = "Id inserido inválido")]
    public int ArtistaId { get; set; }
    public int AlbumId { get; set; }
}
