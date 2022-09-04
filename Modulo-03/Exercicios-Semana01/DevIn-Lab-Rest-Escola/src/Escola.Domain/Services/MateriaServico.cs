using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;

namespace Escola.Domain.Services;

public class MateriaServico : IMateriaServico
{
    private readonly IMateriaRepositorio _materiaRepositorio;
    public MateriaServico(IMateriaRepositorio materiaRepositorio)
    {
        _materiaRepositorio = materiaRepositorio;
    }
    public void Alterar(MateriaDTO boletim, int id)
    {
        throw new NotImplementedException();
    }

    public void ExcluirMateria(int boletimId, int materiaId)
    {
        throw new NotImplementedException();
    }

    public void Inserir(MateriaDTO boletim)
    {
        throw new NotImplementedException();
    }

    public MateriaDTO ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IList<MateriaDTO> ObterPorNome(string nome)
    {
        throw new NotImplementedException();
    }

    public IList<MateriaDTO> ObterTodos()
    {
        return _materiaRepositorio
            .ObterTodos()
            .Select(m => new MateriaDTO(m))
            .ToList();
    }
}
