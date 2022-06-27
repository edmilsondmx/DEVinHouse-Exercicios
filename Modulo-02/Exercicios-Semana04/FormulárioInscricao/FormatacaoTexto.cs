using FormularioInscricao.Models;
namespace FormularioInscricao;

public static class FormatacaoTexto
{
    public static string Formatacao(string? nome, string? curso, decimal valorCurso)
    {
        return $"Nome: {nome} | Curso: {curso} | Valor do Curso: {valorCurso.ToString("c")}";
    }
    public static string Formatacao(string? nome, string? curso, decimal valorCurso, decimal valorDesconto)
    {
        return $"Nome: {nome} | Curso: {curso} | Valor do Curso: {valorCurso.ToString("c")} | Valor Desconto: {valorDesconto.ToString("c")}";
    }
    public static string Formatacao(string? nome, string? curso, decimal valorCurso, decimal valorDesconto, int idade)
    {
        return $"Nome: {nome} | Curso: {curso} | Valor do Curso: {valorCurso.ToString("c")} | Valor Desconto: {valorDesconto.ToString("c")} | Idade: {idade}";
    }
}