using Escola.Domain.DTO;
using Escola.Domain.Exceptions;
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
        var materia = _materiaRepositorio.ObterPorId(id);
        if(materia == null)
            throw new ExisteRegistroException("Materia não encontrada!");
        
        return new MateriaDTO(materia);
    }

    public IList<MateriaDTO> ObterPorNome(string nome)
    {
        var materias = _materiaRepositorio.ObterPorNome(nome);
        if(materias.Count == 0)
            throw new ExisteRegistroException("Materias não encontradas!");

        return _materiaRepositorio.ObterPorNome(nome).Select(m => new MateriaDTO(m)).ToList();
    }

    public IList<MateriaDTO> ObterTodos()
    {
        return _materiaRepositorio
            .ObterTodos()
            .Select(m => new MateriaDTO(m))
            .ToList();
    }
}
