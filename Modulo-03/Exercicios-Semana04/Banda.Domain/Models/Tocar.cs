using Banda.Domain.DTOs;

namespace Banda.Domain.Models;

public class Tocar
{
    public int Id { get; set; }
    public string Descrição { get; set; }
    public string NomeMusica { get; set; }
    public int SequenciaMusica { get; set; }

    public void Update(TocarDTO dto)
    {
        Descrição = dto.Descrição;
        NomeMusica = dto.NomeMusica;
        SequenciaMusica = dto.SequenciaMusica;
    }
}
