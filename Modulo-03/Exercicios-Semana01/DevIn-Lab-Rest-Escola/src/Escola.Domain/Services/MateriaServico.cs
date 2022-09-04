using Escola.Domain.DTO;
using Escola.Domain.Exceptions;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;

namespace Escola.Domain.Services;

public class MateriaServico : IMateriaServico
{
    private readonly IMateriaRepositorio _materiaRepositorio;
    public MateriaServico(IMateriaRepositorio materiaRepositorio)
    {
        _materiaRepositorio = materiaRepositorio;
    }
    public void Alterar(MateriaDTO materia, int id)
    {
        var materiaDb = _materiaRepositorio.ObterPorId(id);

        if(materiaDb == null)
            throw new ExisteRegistroException("Materia não encontrada!");

        materiaDb.Update(materia);

        _materiaRepositorio.Alterar(materiaDb);
    }

    public void Excluir(int materiaId)
    {
        var materiaDb = _materiaRepositorio.ObterPorId(materiaId);
        if(materiaDb == null)
            throw new ExisteRegistroException("Materia não encontrada!");
        
        _materiaRepositorio.Excluir(materiaDb);

    }

    public void Inserir(MateriaDTO materia)
    {
        var existeMateria = _materiaRepositorio
            .ObterPorNome(materia.Nome)
            .FirstOrDefault();
        
        if(existeMateria != null)
            throw new ExisteRegistroException("Já existe Materia cadastrada!");

        _materiaRepositorio.Inserir(new Materia(materia));
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
