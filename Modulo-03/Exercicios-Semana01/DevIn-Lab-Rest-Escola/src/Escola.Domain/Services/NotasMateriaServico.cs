using Escola.Domain.DTO;
using Escola.Domain.Exceptions;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;

namespace Escola.Domain.Services;

public class NotasMateriaServico : INotasMateriaServico
{
    private readonly INotasMateriaRepositorio _notasMateriaRepositorio;
    public NotasMateriaServico(INotasMateriaRepositorio notasMateriaRepositorio)
    {
        _notasMateriaRepositorio = notasMateriaRepositorio;
    }

    public void Alterar(NotasMateriaDTO notasMateria, int notasMateriaId)
    {
        throw new NotImplementedException();
    }

    public void Excluir(int notasMateriaId)
    {
        throw new NotImplementedException();
    }

    public void Inserir(NotasMateriaDTO notasMateria)
    {
        throw new NotImplementedException();
    }

    public IList<NotasMateriaDTO> ObterPorBoletim(Guid alunoId, int boletimId)
    {
        var notasMateriaDb = _notasMateriaRepositorio
            .ObterTodos()
            .Where(nm => nm.BoletimId == boletimId && nm.Boletim.AlunoId == alunoId);

        if(notasMateriaDb == null)
            throw new ExisteRegistroException("Registro não encontrado!");
        
        return notasMateriaDb.Select(nm => new NotasMateriaDTO(nm)).ToList();
    }

    public NotasMateriaDTO ObterPorId(int id)
    {
        var notasMateriaDb = _notasMateriaRepositorio.ObterPorId(id);
        if(notasMateriaDb == null)
            throw new ExisteRegistroException("Registro não encontrado!");
        
        return new NotasMateriaDTO(notasMateriaDb);
    }

    public IList<NotasMateriaDTO> ObterTodos()
    {
        return _notasMateriaRepositorio
            .ObterTodos()
            .Select(nm => new NotasMateriaDTO(nm))
            .ToList();
    }
}
