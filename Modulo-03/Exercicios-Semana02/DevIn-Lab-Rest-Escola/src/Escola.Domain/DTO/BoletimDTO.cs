using Escola.Domain.Models;

namespace Escola.Domain.DTO;

public class BoletimDTO : BaseDTO<BoletimDTO>
{
    public int Id { get; set; }
    public string Periodo { get; set; }
    public int Faltas { get; set; }
    public Guid AlunoId  { get; set; }

    public BoletimDTO(Boletim boletim)
    {
        Id = boletim.Id;
        Periodo = boletim.Periodo;
        Faltas = boletim.Faltas;
        AlunoId = boletim.AlunoId;
    }
    public BoletimDTO()
    {
        
    }
}
