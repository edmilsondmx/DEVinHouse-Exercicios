using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rh.Api.DTOs;
using Rh.Api.Models;

namespace Rh.Api.Interfaces.Service;

public interface IFuncionarioService
{
    IList<FuncionarioDTO> ObterTodos();
    FuncionarioDTO ObterPorId(int id);
    FuncionarioDTO ObterPorUsuario(string nome, string senha);
    void CadastrarFuncionario(FuncionarioDTO funcionario);
    void Editar(FuncionarioDTO funcionario);
    void Remover(FuncionarioDTO funcionario);
}
