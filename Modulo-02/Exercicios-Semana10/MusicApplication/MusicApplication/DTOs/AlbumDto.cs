using System.ComponentModel.DataAnnotations;

namespace MusicApplication.DTOs;

public class AlbumDto
{

    [Required(ErrorMessage = "O nome do Album é obrigatório.")]
    public string Nome { get; set; }
    [Range(1500, 3000, ErrorMessage = "o ano de lançamento precisa ser válido!")]
    public int Ano { get; set; }
    [Required(ErrorMessage ="O id do artista é obrigatório.")]
    [Range(1, int.MaxValue, ErrorMessage = "O id do artita precisa ser válido!")]
    public int ArtistaId { get; set; }
}
