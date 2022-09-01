namespace MusicApplication.Api.ViewModels;

public class RetornoComFalhaViewModel
{
    public string Falha { get; set; }
    public RetornoComFalhaViewModel(string falha)
    {
        Falha = falha;
    }

    
}
public class ValidEmail
{
    static bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}



