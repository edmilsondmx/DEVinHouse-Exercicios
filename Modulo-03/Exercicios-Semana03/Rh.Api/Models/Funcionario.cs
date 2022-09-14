using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rh.Api.Enuns;

namespace Rh.Api.Models;

public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; }
    public Permissoes Permissao { get; set; }
    public decimal Salario { get; set; }

}
