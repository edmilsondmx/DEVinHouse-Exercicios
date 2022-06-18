using GeraEstoque.Models;
namespace GeraEstoque.Repositories;

public class ProdutoRepository
{
    public IList<Produto> ListaDeProdutos;

    public ProdutoRepository()
    {
        ListaDeProdutos = new List<Produto>();
    }
}