using MongoDB.Driver;
using MongoDB_Net.Domain.Entities;
using MongoDB_Net.Domain.Interfaces;
using MongoDB_Net.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_Net.Infra.Data.Repositories
{
    public  class InfectadoRepository : IInfectadoRepository
    {
        private readonly ApplicationMongoDB _applicationMongoDB;
        IMongoCollection<Infectado> _infectadosCollection;

        public InfectadoRepository(ApplicationMongoDB applicationMongoDB)
        {
            _applicationMongoDB = applicationMongoDB;
            _infectadosCollection = _applicationMongoDB.DB.GetCollection<Infectado>(typeof(Infectado).Name.ToLower());
        }

        public Task<IEnumerable<Infectado>> GetInfectados()
        {
            throw new NotImplementedException();
        }

        public Task<Infectado> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public void Create(Infectado infectado)
        {
            _infectadosCollection.InsertOne(infectado);
        }

        public Task<Infectado> Update(Infectado infectado)
        {
            throw new NotImplementedException();
        }

        public Task<Infectado> Remove(Infectado infectado)
        {
            throw new NotImplementedException();
        }
    }
}
