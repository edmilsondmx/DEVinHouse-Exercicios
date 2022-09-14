using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rh.Api.DTOs;
using Rh.Api.Enuns;

namespace Rh.Api.Models;

public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; }
    public Permissoes Permissao { get; set; }
    public decimal Salario { get; set; }

    public Funcionario()
    {
        
    }
    public Funcionario(FuncionarioDTO funcionario)
    {
        Nome = funcionario.Nome;
        Senha = funcionario.Senha;
        Permissao = funcionario.Permissao;
        Salario = funcionario.Salario;
    }

    public void Update(FuncionarioDTO funcionario)
    {
        Nome = funcionario.Nome;
        Senha = funcionario.Senha;
        Permissao = funcionario.Permissao;
        Salario = funcionario.Salario;
    }
    public void Update(Funcionario funcionario)
    {
        Nome = funcionario.Nome;
        Senha = funcionario.Senha;
        Permissao = funcionario.Permissao;
        Salario = funcionario.Salario;
    }

}
