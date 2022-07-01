namespace Exercicio05.Entidades;

public class Funcionario
{
    public string? Nome { get; set; }
    public string? Id { get; set; }
    public Funcionario()
    {
    }
    public Funcionario(string? nome, string? id)
    {
        Nome = nome;
        Id = id;
    }

}

[Serializable]
public class NomeFuncionarioInvalidoException : Exception
{
    public NomeFuncionarioInvalidoException()
    {
    }
    public NomeFuncionarioInvalidoException(string nome)
    : base(String.Format($"Nome do Funcionário invalido: {nome}"))
    {

    }
    
}
public class IdFuncionarioInvalidoException : Exception
{
    public IdFuncionarioInvalidoException()
    {
    }
    public IdFuncionarioInvalidoException(string? id)
    : base(String.Format($"Id do Funcionário invalido: {id}"))
    {

    }
    
}