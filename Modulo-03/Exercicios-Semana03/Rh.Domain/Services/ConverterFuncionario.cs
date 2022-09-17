using Rh.Api.DTOs;
using Rh.Api.Enuns;
using Rh.Domain.DTOs;

namespace Rh.Domain.Services;

public static class ConverterFuncionario
{
    public static UserDto ToDto(FuncionarioDTO dto)
    {
        return new UserDto{
            Id = dto.Id,
            Nome = dto.Nome,
            Permissao = dto.Permissao.GetName(),
            Salario = dto.Salario
        };
    }
    public static IList<UserDto> ToDto(IList<FuncionarioDTO> listDto)
    {
        return listDto.Select(f => ToDto(f)).ToList();
    }
}
