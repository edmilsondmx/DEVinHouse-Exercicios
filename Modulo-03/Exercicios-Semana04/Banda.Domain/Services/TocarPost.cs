using AutoMapper;
using Banda.Domain.DTOs;
using Banda.Domain.Interfaces.Repositorio;
using Banda.Domain.Interfaces.Servico;
using Banda.Domain.Models;

namespace Banda.Domain.Services;

internal class TocarPost : ITocarPost
{
    private readonly ITocarRepositorio _tocarRepositorio;
    private readonly IMapper _mapper;

    public TocarPost(ITocarRepositorio tocarRepositorio, IMapper mapper)
    {
        _tocarRepositorio = tocarRepositorio;
        _mapper = mapper;
    }
    public void Inserir(TocarDTO dto)
    {
        var tocarDb = _tocarRepositorio.Listar().FirstOrDefault(t => t.NomeMusica == dto.NomeMusica);

        if(tocarDb != null)
            throw new Exception("Música já cadastrada no banco!");
            
        _tocarRepositorio.Inserir(_mapper.Map<Tocar>(dto));
    }
}
