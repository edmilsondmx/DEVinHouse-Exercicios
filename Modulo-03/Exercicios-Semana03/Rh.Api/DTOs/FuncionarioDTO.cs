using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rh.Api.Enuns;
using Rh.Api.Models;

namespace Rh.Api.DTOs
{
    public class FuncionarioDTO
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Permissoes Permissao { get; set; }
        public decimal Salario { get; set; }

        public FuncionarioDTO()
        {
            
        }
        public FuncionarioDTO(Funcionario funcionario)
        {
            Nome = funcionario.Nome;
            Senha = funcionario.Senha;
            Permissao = funcionario.Permissao;
            Salario = funcionario.Salario;
        }
    }
}