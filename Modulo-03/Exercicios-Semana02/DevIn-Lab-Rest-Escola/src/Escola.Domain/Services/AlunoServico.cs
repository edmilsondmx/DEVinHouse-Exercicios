using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.DTO;
using Escola.Domain.Models;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Exceptions;

namespace Escola.Domain.Services
{
    public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoServico(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public void Alterar(AlunoDTO aluno)
        {
            Aluno alunoDb = _alunoRepositorio.ObterPorId(aluno.Id);

            alunoDb.Update(aluno);

            /* alunoDb.Nome = aluno.Nome;
            alunoDb.Sobrenome = aluno.Sobrenome;
            alunoDb.Email = aluno.Email;
            alunoDb.DataNascimento = aluno.DataNascimento; */

            _alunoRepositorio.Alterar(alunoDb);
        }

        public void Excluir(Guid id)
        {
            var aluno = _alunoRepositorio.ObterPorId(id);
            _alunoRepositorio.Excluir(aluno);
        }

        public void Inserir(AlunoDTO aluno)
        {
            if(MenorDeIdade(aluno.DataNascimento))
                throw new MenorIdadeException("Aluno precisa ser maior de Idade!");
            
            if(_alunoRepositorio.ExisteMatricula(aluno.Matricula))
                throw new DuplicadoException("Matricula já existente!");

            _alunoRepositorio.Inserir(new Aluno(aluno));
        }

        private bool MenorDeIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if(DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade = idade - 1;
            } 
            return idade < 18;
        }

        public AlunoDTO ObterPorId(Guid id)
        {
            return new AlunoDTO(_alunoRepositorio.ObterPorId(id));
        }

        public IList<AlunoDTO> ObterTodos(Paginacao paginacao)
        {   
            return _alunoRepositorio.ObterTodos(paginacao)
                .Select(x => new AlunoDTO(x)).ToList();

            /* var listaAlunos = _alunoRepositorio.ObterTodos().ToArray();

            List<AlunoDTO> listaAlunosDto = new List<AlunoDTO>();

            for (int i = 0; i < listaAlunos.Length ; i++)
            {
                listaAlunosDto.Add(new AlunoDTO(listaAlunos[i]));
            }

            return listaAlunosDto; */
        }
        public int ObterTotal()
        {
            return _alunoRepositorio.ObterTotal();
        }
    }
}