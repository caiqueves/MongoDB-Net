using AutoMapper;
using MongoDB_Net.Application.DTOs;
using MongoDB_Net.Domain.Entities;

namespace MongoDB_Net.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Infectado, InfectadoDTO>().ReverseMap();
        }
    }
}
