namespace Uber;

public class Corrida
{
    public Endereco? Origem { get; set; }
    public Endereco? Destino { get; set; }
   
    public void SolicitarCorrida()
    {
        if(Origem == null || Destino == null)
            throw new Exception("Os campos de Origem e Destino devem ser preenchidos!");

        //mostrar valor da corrida!
    }
}
