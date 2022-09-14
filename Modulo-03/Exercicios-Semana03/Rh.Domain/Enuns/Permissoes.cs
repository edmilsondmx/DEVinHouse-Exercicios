using System.ComponentModel.DataAnnotations;

namespace Rh.Api.Enuns;

public enum Permissoes
{
    [Display(Name = "Funcionário")]
    Funcionario,
    [Display(Name = "Gerente")]
    Gerente,
    [Display(Name = "Administrador")]
    Administrador
}
