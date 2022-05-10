using AutoMapper;
using MongoDB_Net.Application.DTOs;
using MongoDB_Net.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
