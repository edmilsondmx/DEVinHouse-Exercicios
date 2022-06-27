using FormularioInscricao.Models;
namespace FormularioInscricao;

public class CursoSelecionado
{
    public IList<FichaInscricao> Cursos { get; set; }

    public CursoSelecionado()
    {
        Cursos = new List<FichaInscricao>();

    }

}