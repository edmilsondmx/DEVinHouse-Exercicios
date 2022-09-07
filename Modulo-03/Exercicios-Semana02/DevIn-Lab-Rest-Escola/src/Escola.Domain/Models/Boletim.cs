using Escola.Domain.DTO;

namespace Escola.Domain.Models;

public class Boletim
{
    public int Id { get; set; }
    public string Periodo { get; set; }
    public int Faltas { get; set; }
    public Guid AlunoId  { get; set; }
    public virtual Aluno Aluno { get; set; }
    public virtual List<NotasMateria> Notas { get; set; }

    public Boletim(BoletimDTO boletim)
    {
        Periodo = boletim.Periodo;
        Faltas = boletim.Faltas;
        AlunoId = boletim.AlunoId;
    }
    public Boletim()
    {

    }

    public void Update(BoletimDTO boletim)
    {
        Periodo = boletim.Periodo;
        Faltas = boletim.Faltas;
        AlunoId = boletim.AlunoId;
    }
}
