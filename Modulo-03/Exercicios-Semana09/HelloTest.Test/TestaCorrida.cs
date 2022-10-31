using System.Reflection;
using Uber;
namespace HelloTest.Test;

public class Tests
{
    [Test]
    public void VerificaOrigemEDestinoPreenchidos()
    {
        var corrida = new Corrida();

        Assert.Catch(() => {
           corrida.SolicitarCorrida(); 
        });

        corrida.Origem = new Endereco {
            Rua = "rua santa lucia",
            Numero = 52,
            Bairro = "Jardins"
        };
        corrida.Destino = new Endereco {
            Rua = "rua ventania",
            Numero = 886,
            Bairro = "Mooca"
        };

        Assert.DoesNotThrow(() => {
           corrida.SolicitarCorrida(); 
        });
    }
}