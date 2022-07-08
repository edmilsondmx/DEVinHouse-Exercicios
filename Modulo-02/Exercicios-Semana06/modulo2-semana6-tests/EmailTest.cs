using System.Text;

namespace modulo2_semana6_tests;

public class EmailTest : ConfiguracaoHostApi
{
    [Theory]
    [InlineData("teste@teste.com.br")]
    public async Task Consumir_Api_Validar_Email_Sucesso(string email)
    {
        var resultado = await client.GetAsync($"/ExercicioEmail/{email}");
        Assert.NotNull(resultado);

        string expectativa = "E-mail válido!";
        var responseApi = await resultado.Content.ReadAsStringAsync();
        Assert.NotNull(responseApi);
        Assert.Equal(expectativa, responseApi);
    }

}