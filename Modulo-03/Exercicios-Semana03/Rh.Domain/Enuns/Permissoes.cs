using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Serialization;

namespace Rh.Api.Enuns;

public enum Permissoes
{
    [XmlEnumAttribute("F")]
    [Display(Description = "Funcionário")]
    Funcionario = 1,
    [XmlEnumAttribute("G")]
    [Display(Description = "Gerente")]
    Gerente,
    [XmlEnumAttribute("A")]
    [Display(Description = "Adminstrador")]
    Administrador
    
}

