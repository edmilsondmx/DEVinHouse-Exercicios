using System.Text;

namespace modulo2_semana6_tests;

public class ExemploTest : ConfiguracaoHostApi
{
    [Theory]
    [InlineData(500)]
    public void Consumir_Api_Exemplo_Com_Valor_Maior_Que_10_Sucesso(int valor)
    {
        var resultado = client.GetAsync($"/ExemploTest/{valor}").GetAwaiter().GetResult();
        Assert.NotNull(resultado);

        var responseApi = resultado.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        Assert.NotNull(responseApi);
        Assert.Equal("O Retorno do Valor é maior que dez", responseApi);
    }

    [Theory]
    [InlineData(10)]
    public async Task Consumir_Api_Exemplo_Com_Valor_Maior_Que_10_Erro(int valor)
    {
        var resultado = await client.GetAsync($"/ExemploTest/{valor}");
        Assert.NotNull(resultado);

        var responseApi = await resultado.Content.ReadAsStringAsync();
        Assert.NotNull(responseApi);
        Assert.Equal("O Retorno do Valor é menor que dez", responseApi);
        Assert.NotEqual("O Retorno do Valor é maior que dez", responseApi);
    }

    [Fact]
    public void Gravar_Dados_Na_Tabela_Inscricao_Sucesso()
    {
        //Validar Dados
        Salario salario = new Salario(1,1,1);
        Assert.NotEqual(0, salario.Id);
    }


    [Fact]
    public void Exemplo_Metodod_InputTrue_ReturnFalse()
    {
        var result = true;
        Assert.True(result, "Erro no método");
    }

    [Fact]
    public void Aula_01_Exemplo_Conversao_String_Para_Numero()
    {
        string mensagem = "OLÁ MUNDO !";
        int numero = Convert.ToInt32(mensagem);
    }

    /// <summary>
    /// Exemplo aula 01
    /// </summary>
    /// <exception cref="Exception"></exception>
    [Fact]
    public void Aula_01_Criar_Arquivo_Texto()
    {
        StringBuilder stringBuilder = new();

        stringBuilder!.AppendLine("AULA 01");
        stringBuilder!.AppendLine($"DATA E HORA {DateTime.Now}");

        var file = $@"D:\dev-in-house\Aula-01\Aula-{DateTime.Now.ToString("HHmmss")}.txt";
        string mensagem = "";

        // Escrever o arquivo
        try
        {
            //using (StreamWriter streamWriter = new StreamWriter(file))
            //{
            //    streamWriter.WriteLine(stringBuilder);
            //    streamWriter.Flush();
            //}

            StreamWriter streamWriter = new StreamWriter(file);
            streamWriter.WriteLine(stringBuilder);

            // Para simular CustomErrorException comentar a linha  streamWriter = null;
            // Para simular Exception comentar as tres linhas 
            streamWriter.Flush();
            streamWriter.Close();
            //streamWriter = null;

            if (streamWriter != null)
            {
                throw new CustomErrorException($"ERRO NO ARQUIVO TEXTO, FECHAR CONEXÃO DO {nameof(streamWriter)}. AULA 01");
            }

            // Ler o arquivo
            using (StreamReader reader = new StreamReader(file))
            {
                mensagem = reader.ReadToEnd();
            }
        }
        catch (CustomErrorException exCustom)
        {
            mensagem = exCustom.Message;
        }
        catch (Exception ex)
        {
            mensagem = ex.StackTrace;
            throw new Exception("Erro ao escrever aquirov.", ex);
        }
        finally
        {
            Assert.True(!string.IsNullOrEmpty(mensagem), "Erro na declaração da var mensagem");
        }
    }

    [Serializable]
    public class CustomErrorException : Exception
    {
        public CustomErrorException()
        {
        }

        public CustomErrorException(string mensagemErro) : base(mensagemErro)
        {
        }
    }

    [Theory]
    [InlineData(1000.00, 7.0, 0)]
    [InlineData(59999.99, 15.5, 27.7)]
    [InlineData(3000.11, 8.5, 2.5)]
    public void Calculo_Salario_Ate_Cinco_Mil_Reais_Sucesso(decimal salarioBruto, decimal inss, decimal ir)
    {
        Salario salario = new Salario(salarioBruto, inss, ir);

        bool condicao = salario.CalcularSalarioLiquido() < 5000M;
        string mensagemErro = "Erro ao efeutar o cálculo";

        Assert.NotNull(salario);
        Assert.True(condicao, mensagemErro);
        Assert.Equal("expectativa", "conteudo atual");
        Assert.False(condicao == true, mensagemErro);
        Assert.NotEqual("expectativa", "conteudo atual");
    }

    public class Salario
    {
        public Salario(decimal bruto, decimal inss, decimal ir)
        {
            Bruto = bruto;
            Inss = inss;
            IR = ir;
        }

        public int Id { get; set; }

        public decimal Bruto { get; set; }
        public decimal  Inss { get; set; }
        public decimal IR { get; set; }

        public decimal CalcularSalarioLiquido()
        {
            var liquido = Bruto;

            if(IR > 0)
            {
            }
            
            return liquido;
        }
    }

}