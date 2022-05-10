using MongoDB_Net.Application.DTOs;

namespace MongoDB_Net.Application.Interfaces
{
    public interface IInfectadoService
    {
        Task<IEnumerable<InfectadoDTO>> GetInfectados();
        Task<InfectadoDTO> GetById(int? id);
        Task Add(InfectadoDTO infectadoDto);
        Task Update(InfectadoDTO infectadoDto);
        Task Remove(int? id);
    }
}
