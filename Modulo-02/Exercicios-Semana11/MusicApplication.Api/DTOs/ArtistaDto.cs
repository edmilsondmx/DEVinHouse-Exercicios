using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Api.DTOs;

public class ArtistaDto
{
    [Required (ErrorMessage = "Nome do artista obrigatório")]
    public string Nome { get; set; }

    [Required (ErrorMessage = "Nome Artístico obrigatório")]
    public string NomeArtistico { get; set; }
    public string PaisOrigem { get; set; }
}
