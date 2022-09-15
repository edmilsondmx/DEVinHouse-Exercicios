using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rh.Api.DTOs;
using Rh.Api.Enuns;
using Rh.Api.Interfaces.Repository;
using Rh.Api.Models;
using Rh.Domain.DTOs;

namespace Rh.Api.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private static List<Funcionario> ListaFuncionarios {get; set;} = new List<Funcionario> {
            new Funcionario(){
                Id = "45d1",
                Nome = "Edmilson",
                Permissao = Permissoes.Administrador,
                Salario = 9000m,
                Senha = "2302"
            },
            new Funcionario(){
                Id = "13h8",
                Nome = "Fernando",
                Permissao = Permissoes.Funcionario,
                Salario = 6000m,
                Senha = "1010"
            },
            new Funcionario(){
                Id = "428a",
                Nome = "Ezequiel",
                Permissao = Permissoes.Gerente,
                Salario = 10000m,
                Senha = "1111"
            },
        };

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            funcionario.Id = Guid.NewGuid().ToString().Substring(0, 4);
            ListaFuncionarios.Add(funcionario);
        }

        public void Editar(Funcionario funcionario)
        {
            var funcionarioBd = ListaFuncionarios.Find(f => f.Id == funcionario.Id);
            funcionarioBd.Update(funcionario);
        }

        public Funcionario ObterPorId(string id)
        {
            var funcionario = ListaFuncionarios.Find(f => f.Id == id);
            return funcionario;
        }

        public Funcionario ObterPorUsuario(FuncionarioLoginDto funcionario)
        {
            return ListaFuncionarios.FirstOrDefault(f => f.Nome == funcionario.Nome && f.Senha == funcionario.Senha);
        }

        public IList<Funcionario> ObterTodos()
        {
            return ListaFuncionarios;
        }

        public void Remover(Funcionario funcionario)
        {
            ListaFuncionarios.RemoveAll(f => f.Id == funcionario.Id);
        }

        public bool ExisteFuncionario(Funcionario funcionario)
        {
            return ListaFuncionarios.Any(f => f.Nome == funcionario.Nome && f.Senha == funcionario.Senha);
        }
    }
}