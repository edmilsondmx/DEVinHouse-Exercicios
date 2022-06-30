using System;
using Empresa.Entidades;
namespace Empresa;

internal class Program
{
    static void Main(string[] args)
    {
        Empregado objetoEmpregado = new Empregado(4505, "Edgar Silva");
        System.Console.WriteLine($"Id: {objetoEmpregado.id} | Nome: {objetoEmpregado.nome}");
        objetoEmpregado.Trabalhar();
        objetoEmpregado.IrEmbora();
        objetoEmpregado.TirarFolga();
        System.Console.WriteLine("========================================================");

        SalarioEmpregado objetoSalario = new SalarioEmpregado(8985, "Carlos Mendes", 256, 2550.00);
        System.Console.WriteLine($"Id: {objetoSalario.id} | Nome: {objetoSalario.nome} | Cód. Funcionário: {objetoSalario.codigoFuncionario} | Salário: {objetoSalario.valorSalario.ToString("c")}");
        objetoSalario.Trabalhar();
        objetoSalario.IrEmbora();
        objetoSalario.TirarFolga();
        objetoSalario.CalcularFolhaPagamento();
        System.Console.WriteLine("========================================================");

        Secretaria objetoSecretaria = new Secretaria(4652, "Raquel Silva", 658, 2100.00, 4);
        System.Console.WriteLine($"Id: {objetoSecretaria.id} | Nome: {objetoSecretaria.nome} | Cód. Funcionário: {objetoSecretaria.codigoFuncionario} | Salário: {objetoSecretaria.valorSalario.ToString("c")} | Anos de Empresa: {objetoSecretaria.qtdAnosEmpresa}");
        objetoSecretaria.Trabalhar();
        objetoSecretaria.IrEmbora();
        objetoSecretaria.TirarFolga();
        objetoSecretaria.CalcularFolhaPagamento();
        objetoSecretaria.AtenderCliente();
        objetoSecretaria.RealizarLigacao();
        System.Console.WriteLine("========================================================");

        FuncionarioHorista objetoHorista = new FuncionarioHorista(8546, "Gustavo heez", "11.254.222.0001-88", 11.5);
        System.Console.WriteLine($"Id: {objetoHorista.id} | Nome: {objetoHorista.nome} | CNPJ: {objetoHorista.cnpj} | Taxa: {objetoHorista.taxa}");
        objetoHorista.Trabalhar();
        objetoHorista.IrEmbora();
        objetoHorista.TirarFolga();
        objetoHorista.CalcularTaxa();
        objetoHorista.EmitirNota();
        
        
    }
}