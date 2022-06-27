using GeraEstoque.Repositories;
namespace GeraEstoque.Screens;

class Program
{
    static void Main(string[] args)
    {
        ProdutoRepository repository = new ProdutoRepository();
        
        MenuScreen.Iniciar(repository);
        

    }
    
}