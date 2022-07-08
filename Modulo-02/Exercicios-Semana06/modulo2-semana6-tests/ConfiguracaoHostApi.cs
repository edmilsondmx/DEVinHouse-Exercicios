using Microsoft.AspNetCore.Mvc.Testing;

namespace modulo2_semana6_tests
{
    public class ConfiguracaoHostApi 
    {
        private const string url = "http://localhost:50009";
        private protected HttpClient client;

        public ConfiguracaoHostApi()
        {
            var application = new WebApplicationFactory<Program>();
            application.ClientOptions.BaseAddress = new(url);
            client = application.CreateClient();
        }
    }
}
