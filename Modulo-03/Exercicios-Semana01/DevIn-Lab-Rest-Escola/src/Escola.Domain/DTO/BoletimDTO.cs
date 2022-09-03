using Escola.Domain.Models;

namespace Escola.Domain.DTO;

public class BoletimDTO
{
    public string Periodo { get; set; }
    public int Faltas { get; set; }
    public Guid AlunoId  { get; set; }

    public BoletimDTO(Boletim boletim)
    {
        Periodo = boletim.Periodo;
        Faltas = boletim.Faltas;
        AlunoId = boletim.AlunoId;
    }
    public BoletimDTO()
    {
        
    }
}
