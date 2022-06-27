namespace FormularioInscricao;

public class CobrarCusto
{
    public decimal ValorCurso { get; private set; }
    public decimal ValorMulta { get; private set; }
    public decimal ValorDesconto { get; private set; }

    public decimal Resultado { get; set; }

    public CobrarCusto(decimal valorCurso, decimal valorMulta, decimal valorDesconto)
    {
        ValorCurso = valorCurso;
        ValorMulta = valorMulta;
        ValorDesconto = valorDesconto;

        Resultado = Calculo(valorCurso, valorMulta, valorDesconto);
    }

    public decimal Calculo(decimal valorCurso, decimal valorMulta, decimal valorDesconto)
    {
        if(valorMulta > 0)
            return valorCurso + valorMulta;
        else
            return valorCurso - valorDesconto;
    }

}