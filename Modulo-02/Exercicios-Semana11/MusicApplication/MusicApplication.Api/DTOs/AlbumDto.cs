using System.ComponentModel.DataAnnotations;
using MusicApplication.Api.Models;

namespace MusicApplication.Api.DTOs;

public class AlbumDto
{
    [Required (ErrorMessage = "Nome do artista obrigatório")]
    public string Nome { get; set; }
    [Required (ErrorMessage = "Ano de Lançamento obrigatório")]
    [Range (1500, 3000, ErrorMessage = "Ano inserido inválido")]
    public int AnoLancamento { get; set; }

    [Required (ErrorMessage = "Id do artista é obrigatório")]
    [Range (1, int.MaxValue, ErrorMessage = "Id inserido inválido")]
    public int ArtistaId { get; set; }
}
