using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rh.Api.Models;
using Rh.Domain.DTOs;

namespace Rh.Api.Interfaces.Repository;

public interface IFuncionarioRepository
{
    IList<Funcionario> ObterTodos();
    Funcionario ObterPorId(string id);
    Funcionario ObterPorUsuario(FuncionarioLoginDto funcionario);
    void CadastrarFuncionario(Funcionario funcionario);
    void Editar(Funcionario funcionario);
    void Remover(Funcionario funcionario);
    bool ExisteFuncionario(Funcionario funcionario);
    
}
