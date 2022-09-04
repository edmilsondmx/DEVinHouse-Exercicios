using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Interfaces.Repositories
{
    public interface IMateriaRepositorio
    {
        IList<Materia> ObterTodos();
        Materia ObterPorId(int id);
        IList<Materia> ObterPorNome(string nome);
        void Inserir(Materia boletim);
        void ExcluirMateria(int boletimId, int materiaId);
        void Alterar(Materia boletim, int id);
    }
}
