using Escola.Domain.DTO;
using Escola.Domain.Exceptions;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;

namespace Escola.Domain.Services;

public class NotasMateriaServico : INotasMateriaServico
{
    private readonly INotasMateriaRepositorio _notasMateriaRepositorio;
    public NotasMateriaServico(INotasMateriaRepositorio notasMateriaRepositorio)
    {
        _notasMateriaRepositorio = notasMateriaRepositorio;
    }

    public void Alterar(NotasMateriaDTO notasMateria)
    {
        var notasMateriaDb = _notasMateriaRepositorio.ObterPorId(notasMateria.Id);
        ExisteRegistro(notasMateriaDb);
        
        notasMateriaDb.Uptade(notasMateria);
        _notasMateriaRepositorio.Alterar(notasMateriaDb);
        
    }

    public void Excluir(int notasMateriaId)
    {
        var notasMateriaDb = _notasMateriaRepositorio.ObterPorId(notasMateriaId);
        ExisteRegistro(notasMateriaDb);
        
        _notasMateriaRepositorio.Excluir(notasMateriaDb);
    }

    public void Inserir(NotasMateriaDTO notasMateria)
    {
        _notasMateriaRepositorio.Inserir(new NotasMateria(notasMateria));
    }

    public IList<NotasMateriaDTO> ObterPorBoletim(Guid alunoId, int boletimId)
    {
        var notasMateriaDb = _notasMateriaRepositorio
            .ObterTodos()
            .Where(nm => nm.BoletimId == boletimId && nm.Boletim.AlunoId == alunoId);

        if(notasMateriaDb.Count() == 0)
            throw new ExisteRegistroException("Registro não encontrado!");
        
        return notasMateriaDb.Select(nm => new NotasMateriaDTO(nm)).ToList();
    }

    public NotasMateriaDTO ObterPorId(int id)
    {
        var notasMateriaDb = _notasMateriaRepositorio.ObterPorId(id);
        ExisteRegistro(notasMateriaDb);
        
        return new NotasMateriaDTO(notasMateriaDb);
    }

    public IList<NotasMateriaDTO> ObterTodos()
    {
        return _notasMateriaRepositorio
            .ObterTodos()
            .Select(nm => new NotasMateriaDTO(nm))
            .ToList();
    }

    private void ExisteRegistro(NotasMateria notasMateria)
    {
        if(notasMateria == null)
            throw new ExisteRegistroException("Registro não encontrado!");
    }
}
