using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Serialization;

namespace Rh.Api.Enuns;

public enum Permissoes
{
    [XmlEnumAttribute("F")]
    [Display(Name = "Funcionário")]
    Funcionario = 1,
    [XmlEnumAttribute("G")]
    [Display(Name = "Gerente")]
    Gerente,
    [XmlEnumAttribute("A")]
    [Display(Name = "Adminstrador")]
    Administrador
    
}

 public static class EnumExtensions
  {
    public static string GetDisplayName(this Enum enumValue)
    {
      return enumValue.GetType()
        .GetMember(enumValue.ToString())
        .First()
        .GetCustomAttribute<DisplayAttribute>()
        ?.GetName();
    }
  }

