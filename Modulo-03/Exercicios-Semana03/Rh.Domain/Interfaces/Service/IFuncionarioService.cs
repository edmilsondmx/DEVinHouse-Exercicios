using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rh.Api.DTOs;
using Rh.Api.Models;
using Rh.Domain.DTOs;

namespace Rh.Api.Interfaces.Service;

public interface IFuncionarioService
{
    IList<FuncionarioDTO> ObterTodos();
    FuncionarioDTO ObterPorId(string id);
    Funcionario ObterPorUsuario(FuncionarioLoginDto funcionario);
    void CadastrarFuncionario(FuncionarioDTO funcionario);
    void Editar(FuncionarioDTO funcionario);
    void Remover(FuncionarioDTO funcionario);
}
