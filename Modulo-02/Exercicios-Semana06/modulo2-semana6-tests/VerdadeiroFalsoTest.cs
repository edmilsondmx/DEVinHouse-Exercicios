using System.Text;

namespace modulo2_semana6_tests;

public class VerdadeiroFalsoTest : ConfiguracaoHostApi
{
    [Theory]
    [InlineData("verdadeiro")]
    [InlineData("falso")]
    public async Task Consumir_Api_Valor_Verdadeiro_Ou_Falso_Sucesso(string tipo)
    {
        var resultado = await client.GetAsync($"/ExercicioVerdadeiroFalso/{tipo}");
        Assert.NotNull(resultado);

        string expectativa = "O texto foi igual a verdadeiro ou falso";
        var responseApi = await resultado.Content.ReadAsStringAsync();
        Assert.NotNull(responseApi);
        Assert.Equal(expectativa, responseApi);

    }

    [Theory]
    [InlineData("Qualquer coisa")]
    public async Task Consumir_Api_Valor_Verdadeiro_Ou_Falso_Erro(string tipo)
    {
        var resultado = await client.GetAsync($"/ExercicioVerdadeiroFalso/{tipo}");
        Assert.NotNull(resultado);

        string expectativa = "O texto foi diferente de verdadeiro ou falso";
        var responseApi = await resultado.Content.ReadAsStringAsync();
        Assert.NotNull(responseApi);
        Assert.Equal(expectativa, responseApi);

    }

}