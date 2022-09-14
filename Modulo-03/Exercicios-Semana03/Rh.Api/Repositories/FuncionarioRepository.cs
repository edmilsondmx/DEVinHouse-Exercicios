using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rh.Api.Interfaces.Repository;
using Rh.Api.Models;

namespace Rh.Api.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        public static List<Funcionario> ListaFuncionarios {get; set;} = new();

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            ListaFuncionarios.Add(funcionario);
        }

        public void Editar(Funcionario funcionario)
        {
            var funcionarioBd = ListaFuncionarios.Find(f => f.Id == funcionario.Id);
            funcionarioBd.Update(funcionario);
        }

        public Funcionario ObterPorId(int id)
        {
            return ListaFuncionarios.Find(f => f.Id == id);
        }

        public Funcionario ObterPorUsuario(string nome, string senha)
        {
            return ListaFuncionarios.Where(f => f.Nome == nome && f.Senha == senha).FirstOrDefault();
        }

        public IList<Funcionario> ObterTodos()
        {
            return ListaFuncionarios;
        }

        public void Remover(Funcionario funcionario)
        {
            ListaFuncionarios.Remove(funcionario);
        }

        public bool ExisteFuncionario(Funcionario funcionario)
        {
            return ListaFuncionarios.Any(f => f.Nome == funcionario.Nome && f.Senha == funcionario.Senha);
        }
    }
}