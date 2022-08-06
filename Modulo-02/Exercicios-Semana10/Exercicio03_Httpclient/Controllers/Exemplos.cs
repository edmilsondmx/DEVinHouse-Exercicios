using System.Net.Http.Headers;

namespace Exercicio03_HttpClient.Controllers;

public class Exemplos
{
    public static void Post()
    {
        Console.WriteLine("Exemplo utilização HttpClient - verbo Post - Sentim-api");

        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://sentim-api.herokuapp.com/api/v1/"),
            Content = new StringContent("{ \"text\": \"Estou feliz\" }")
            {
                Headers =
                {
                    ContentType = new MediaTypeHeaderValue("application/json")
                }
            }
        };
        using var response = client.Send(request);
        
        System.Console.WriteLine("Retorno da API:");
        Console.WriteLine($"Status Code: {response.StatusCode}");
        System.Console.WriteLine($"Corpo: {response.Content.ReadAsStringAsync().Result}");
        System.Console.WriteLine($"Headers: {string.Join(',', response.Headers.Select(h => $"{h.Key}={string.Join(',', h.Value)}"))}");
        
    }

    public static void Get()
    {
        Console.WriteLine("Exemplo utilização HttpClient - verbo Get - Fipe - API");

        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://parallelum.com.br/fipe/api/v1/carros/marcas/59/modelos/4797/anos/2012-1"),
        };
        using var response = client.Send(request);
        
        System.Console.WriteLine("Retorno da API:");
        Console.WriteLine($"Status Code: {response.StatusCode}");
        System.Console.WriteLine($"Corpo: {response.Content.ReadAsStringAsync().Result}");
        System.Console.WriteLine($"Headers: {string.Join(',', response.Headers.Select(h => $"{h.Key}={string.Join(',', h.Value)}"))}");
    }
    
}