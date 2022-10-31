namespace Uber;

public class Corrida
{
    public string Origem { get; set; }
    public string Destino { get; set; }

    public Corrida(string origem, string destino)
    {
        Origem = origem;
        Destino = destino;
    }

    public void SolicitarCorrida()
    {
        if(Origem == null || Destino == null)
            throw new Exception("Os campos de Origem e Destino devem ser preenchidos!");

        //mostrar valor da corrida!
    }
}
