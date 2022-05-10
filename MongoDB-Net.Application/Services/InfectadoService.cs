
using AutoMapper;
using MongoDB_Net.Application.DTOs;
using MongoDB_Net.Application.Interfaces;
using MongoDB_Net.Domain.Entities;
using MongoDB_Net.Domain.Interfaces;

namespace MongoDB_Net.Application.Services
{
    public class InfectadoService : IInfectadoService
    {
        private readonly IInfectadoRepository _infectadoRepository;
        private readonly IMapper _mapper;

        public InfectadoService(IInfectadoRepository infectadoRepository, IMapper mapper)
        {
            _infectadoRepository = infectadoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InfectadoDTO>> GetInfectados()
        {
            var infectadoEntity = await _infectadoRepository.GetInfectados();
            return _mapper.Map<IEnumerable<InfectadoDTO>>(infectadoEntity);
        }

        public async Task<InfectadoDTO> GetById(int? id)
        {
            var infectadoEntity = await _infectadoRepository.GetById(id);
            return _mapper.Map<InfectadoDTO>(infectadoEntity);
        }

        public async Task Add(InfectadoDTO infectadoDto)
        {
            var infectadoEntity = _mapper.Map<Infectado>(infectadoDto);
            _infectadoRepository.Create(infectadoEntity);
        }

        public async Task Update(InfectadoDTO infectadoDto)
        {
            var infectadoEntity = _mapper.Map<Infectado>(infectadoDto);
            await _infectadoRepository.Update(infectadoEntity);
        }

        public async Task Remove(int? id)
        {
            var infectadoEntity = _infectadoRepository.GetById(id).Result;
            await _infectadoRepository.Remove(infectadoEntity);
        }
    }
}
