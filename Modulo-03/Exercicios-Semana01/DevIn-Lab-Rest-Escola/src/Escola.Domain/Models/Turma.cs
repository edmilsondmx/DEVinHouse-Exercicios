namespace Escola.Domain.Models;

public class Turma
{
    public Guid Id { get; set; }
    public string Curso { get; set; }
    public List<Aluno> Alunos { get; set; }
}
