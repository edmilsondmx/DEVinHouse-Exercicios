using AutoMapper;
using Banda.Domain.DTOs;
using Banda.Domain.Models;

namespace Banda.DI.AutoMapper;

public class TocarAutoMapper : Profile
{
    public TocarAutoMapper()
    {
        CreateMap<Tocar, TocarDTO>()
            .ReverseMap();
    }
}
