namespace FormularioInscricao;

public static class ListarCursos
{
    public static void Iniciar(CursoSelecionado cursos)
    {

        Console.Clear();

        System.Console.WriteLine("Lista de Cursos Cadastrados");
        System.Console.WriteLine("===========================");
        System.Console.Write(Environment.NewLine);

        if(cursos.Cursos.Count == 0)
        {
            System.Console.WriteLine("Não há Cursos na Lista!");
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
            Console.ReadLine();
        }
        else
        {

            foreach (var curso in cursos.Cursos)
            {
                if(curso.ValorDesconto == 0)
                    System.Console.WriteLine(FormatacaoTexto.Formatacao(curso.Nome, curso.Curso, curso.ValorCurso));
                else if(curso.ValorDesconto > 0 && curso.Idade < 18)
                    System.Console.WriteLine(FormatacaoTexto.Formatacao(curso.Nome, curso.Curso, curso.ValorCurso, curso.ValorDesconto, curso.Idade));
                else if(curso.ValorDesconto > 0)
                    System.Console.WriteLine(FormatacaoTexto.Formatacao(curso.Nome, curso.Curso, curso.ValorCurso, curso.ValorDesconto));


                System.Console.WriteLine("=======================================================================================================================");
            }
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
            Console.ReadLine();
        }
        
    }
}