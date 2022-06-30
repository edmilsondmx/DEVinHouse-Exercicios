namespace Empresa.Entidades;

public class Empregado
{
    public int id { get; set; }
    public string? nome { get; set; }

    public Empregado()
    {

    }
    public Empregado(int id, string? nome)
    {
        this.id = id;
        this.nome = nome;
    }

    public void Trabalhar()
    {
        System.Console.WriteLine("Trabalhando!");
    }
    public void IrEmbora()
    {
        System.Console.WriteLine("Indo embora!");
    }
    public void TirarFolga()
    {
        System.Console.WriteLine("Tirando folga!");
    }
}