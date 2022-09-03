namespace Escola.Domain.Models;

public class Paginacao
{
    public int Take { get; set; }
    public int Skip { get; set; }

    public Paginacao(int take, int skip)
    {
        Take = take;
        Skip = skip;
    }
    public Paginacao()
    {
        
    }

}
