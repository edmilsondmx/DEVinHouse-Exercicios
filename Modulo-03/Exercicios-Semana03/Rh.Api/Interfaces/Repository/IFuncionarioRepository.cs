using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rh.Api.Models;

namespace Rh.Api.Interfaces.Repository;

public interface IFuncionarioRepository
{
    IList<Funcionario> ObterTodos();
    Funcionario ObterPorId(int id);
    Funcionario ObterPorUsuario(string nome, string senha);
    void CadastrarFuncionario(Funcionario funcionario);
    void Editar(Funcionario funcionario);
    void Remover(Funcionario funcionario);
    bool ExisteFuncionario(Funcionario funcionario);
    
}
