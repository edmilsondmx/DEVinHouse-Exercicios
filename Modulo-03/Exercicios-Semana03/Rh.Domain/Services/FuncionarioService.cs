using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rh.Api.DTOs;
using Rh.Api.Interfaces.Repository;
using Rh.Api.Interfaces.Service;
using Rh.Api.Models;
using Rh.Domain.DTOs;

namespace Rh.Api.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public void CadastrarFuncionario(FuncionarioDTO funcionario)
        {
            if(_funcionarioRepository.ExisteFuncionario(new Funcionario(funcionario)))
                throw new Exception("Funcionario já cadastrado");

            _funcionarioRepository.CadastrarFuncionario(new Funcionario(funcionario));
        }

        public void Editar(FuncionarioDTO funcionario)
        {
            _funcionarioRepository.Editar(new Funcionario(funcionario));
        }

        public FuncionarioDTO ObterPorId(string id)
        {
            return new FuncionarioDTO(_funcionarioRepository.ObterPorId(id));
        }

        public Funcionario ObterPorUsuario(FuncionarioLoginDto funcionario)
        {
            return _funcionarioRepository.ObterPorUsuario(funcionario);
        }

        public IList<FuncionarioDTO> ObterTodos()
        {
            return _funcionarioRepository.ObterTodos().Select(f => new FuncionarioDTO(f)).ToList();
        }

        public void Remover(FuncionarioDTO funcionario)
        {
            _funcionarioRepository.Remover(new Funcionario(funcionario));
        }
    }
}