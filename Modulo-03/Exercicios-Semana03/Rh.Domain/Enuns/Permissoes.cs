using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Rh.Api.Enuns;

public enum Permissoes
{
    [Display(Name = "Funcionário")]
    Funcionario = 1,
    [Display(Name = "Gerente")]
    Gerente,
    [Display(Name = "Adminstrador")]
    Administrador
    
}

