using MongoDB_Net.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
