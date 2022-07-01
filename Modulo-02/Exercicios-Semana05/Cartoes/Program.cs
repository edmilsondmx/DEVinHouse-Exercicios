using System;
using Cartoes.Entidades;
namespace Cartoes;

public class Program
{
    static void Main(string[] args)
    {

        Cartao cartaoVr = new CartaoVR("Visa", 1000);
        System.Console.WriteLine($"O cartão VR, de Bandeira {cartaoVr.bandeira}, possui {cartaoVr.saldo.ToString("c")} de limite e a taxa é de {cartaoVr.VerificarValorTaxaCartao().ToString("c")}.");
        System.Console.WriteLine("========================================================");

        Cartao cartaoVa = new CartaoVA("MasterCard", 500);
        System.Console.WriteLine($"O cartão VA, de Bandeira {cartaoVa.bandeira}, possui {cartaoVa.saldo.ToString("c")} de limite e a taxa é de {cartaoVa.VerificarValorTaxaCartao().ToString("c")}.");
        System.Console.WriteLine("========================================================");

        Cartao cartaoVt = new CartaoVT("Elo", 250);
        System.Console.WriteLine($"O cartão VT, de Bandeira {cartaoVt.bandeira}, possui {cartaoVt.saldo.ToString("c")} de limite e a taxa é de {cartaoVt.VerificarValorTaxaCartao().ToString("c")}.");
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