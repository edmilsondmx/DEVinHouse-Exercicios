using FormularioInscricao.Models;
namespace FormularioInscricao;

static class Program
{
    static void Main(string[] args)
    {
        FichaInscricao ficha01 = new FichaInscricao("Edmilson Gomes", "DEVinHouse", "Bacharel", new DateTime(1990,01,08), 240.00m, 240.00m, 0.0m);

        System.Console.WriteLine(ficha01.ToString());
    }
}