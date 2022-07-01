using System;
using Cartoes.Entidades;
namespace Cartoes;

public class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Qual a bandeira do cartão? ");
        string? bandeira = Console.ReadLine();
        System.Console.Write("Qual o limite do cartão? ");
        double limite = double.Parse(Console.ReadLine()!);
        System.Console.Write("Qual a taxa do cartão(%)? ");
        double taxa = double.Parse(Console.ReadLine()!);
        System.Console.WriteLine("========================================================");

        Cartao cartaoVr = new CartaoVR(bandeira, limite, taxa);
        System.Console.WriteLine($"O cartão de Bandeira {cartaoVr.bandeira}, possui {cartaoVr.saldo.ToString("c")} de limite e a taxa é de {cartaoVr.VerificarValorTaxaCartao().ToString("c")}.");
        System.Console.WriteLine("========================================================");

        Cartao cartaoVa = new CartaoVA("MasterCard", 500, 3);
        System.Console.WriteLine($"O cartão de Bandeira {cartaoVa.bandeira}, possui {cartaoVa.saldo.ToString("c")} de limite e a taxa é de {cartaoVa.VerificarValorTaxaCartao().ToString("c")}.");
        System.Console.WriteLine("========================================================");

        Cartao cartaoVt = new CartaoVA("Elo", 250, 1.5);
        System.Console.WriteLine($"O cartão de Bandeira {cartaoVt.bandeira}, possui {cartaoVt.saldo.ToString("c")} de limite e a taxa é de {cartaoVt.VerificarValorTaxaCartao().ToString("c")}.");
        System.Console.WriteLine("========================================================");


        System.Console.WriteLine("EXEMPLOS UPCASTING E DOWNCASTING");
        //Exemplos UpCasting
        Cartao cartaoUp2 = new CartaoVR();
        CartaoVR cartaoUp = new CartaoVR();
        Cartao novoCartao = cartaoUp;
        System.Console.WriteLine(novoCartao == cartaoUp);

        //Exemplo DownCasting
        CartaoVR cartaoDown = (CartaoVR)cartaoUp2;
        System.Console.WriteLine(cartaoDown == cartaoUp2);
    }
}