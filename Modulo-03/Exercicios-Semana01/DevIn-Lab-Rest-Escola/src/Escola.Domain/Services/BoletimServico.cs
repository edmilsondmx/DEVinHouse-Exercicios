using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;

namespace Escola.Domain.Services;

public class BoletimServico : IBoletimServico
{
    private readonly IBoletimRepositorio _boletimRepositorio;

    public BoletimServico(IBoletimRepositorio boletimRepositorio)
    {
        _boletimRepositorio = boletimRepositorio;
    }

    public void Alterar(BoletimDTO boletim)
    {
        throw new NotImplementedException();
    }

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public void Inserir(BoletimDTO boletim)
    {
        throw new NotImplementedException();
    }

    public BoletimDTO ObterPorId(int id)
    {
        return new BoletimDTO(_boletimRepositorio.ObterPorId(id));        
    }

    public IList<BoletimDTO> ObterPorIdAluno(Guid id, Paginacao paginacao)
    {
        var boletins = _boletimRepositorio.ObterTodos(paginacao).Where(b => b.AlunoId == id);
        return boletins.Select(b => new BoletimDTO(b)).ToList();
    }

    public IList<BoletimDTO> ObterPorNome(string nome, Paginacao paginacao)
    {
        var boletins = _boletimRepositorio
            .ObterTodos(paginacao)
            .Where(b => b.Aluno.Nome
            .Contains(nome));

        return boletins.Select(b => new BoletimDTO(b)).ToList();
    }

    public IList<BoletimDTO> ObterTodos(Paginacao paginacao)
    {
        return _boletimRepositorio.ObterTodos(paginacao).Select(b => new BoletimDTO(b)).ToList();
    }

    public int ObterTotal()
    {
        return _boletimRepositorio.ObterTotal();
    }
}