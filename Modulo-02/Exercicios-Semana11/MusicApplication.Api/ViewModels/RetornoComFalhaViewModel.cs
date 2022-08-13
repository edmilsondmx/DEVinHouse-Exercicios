namespace MusicApplication.Api.ViewModels;

public class RetornoComFalhaViewModel
{
    public RetornoComFalhaViewModel(string falha)
    {
        Falha = falha;
    }

    public string Falha { get; set; }
}
