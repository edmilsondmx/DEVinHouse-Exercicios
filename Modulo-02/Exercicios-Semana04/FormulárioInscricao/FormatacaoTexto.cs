using FormularioInscricao.Models;
namespace FormularioInscricao;

public static class FormatacaoTexto
{

    
    public static string Formatacao(string? nome, string? curso, decimal valorCurso, decimal resultado)
    {
        return $"Nome: {nome} | Curso: {curso} | Valor do Curso: {valorCurso.ToString("c")} | Total: {resultado.ToString("c")}";
    }
    public static string Formatacao(string? nome, string? curso, decimal valorCurso, decimal valorDesconto, decimal resultado)
    {
        return $"Nome: {nome} | Curso: {curso} | Valor do Curso: {valorCurso.ToString("c")} | Valor Desconto: {valorDesconto.ToString("c")} | Total: {resultado.ToString("c")}";
    }
    public static string Formatacao(string? nome, string? curso, decimal valorCurso, decimal valorDesconto, int idade, decimal resultado)
    {
        return $"Nome: {nome} | Curso: {curso} | Valor do Curso: {valorCurso.ToString("c")} | Valor Desconto: {valorDesconto.ToString("c")} | Idade: {idade} | Total: {resultado.ToString("c")}";
    }
}