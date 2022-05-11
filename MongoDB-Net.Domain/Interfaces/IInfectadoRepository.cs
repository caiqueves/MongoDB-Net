using MongoDB_Net.Domain.Entities;

namespace MongoDB_Net.Domain.Interfaces
{
    public interface IInfectadoRepository
    {
        Task<IEnumerable<Infectado>> GetInfectados();
        Task<Infectado> GetById(int? id);
        void Create(Infectado infectado);
        Task<Infectado> Update(Infectado infectado);
        Task<Infectado> Remove(Infectado infectado);
    }
}
