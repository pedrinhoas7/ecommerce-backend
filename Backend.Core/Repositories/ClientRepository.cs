using Backend.Core.Entities;
using Backend.Core.Interfaces;
using Backend.Domain.Base;
using Backend.Domain.Connection;

namespace Backend.Core.Repositories
{
    public class ClientRepository : NoSqlRepository<ClientEntity>, IClientRepository
    {
        public ClientRepository(IDatabaseSettings settings) : base(settings) { }
        public IEnumerable<ClientEntity> GetClients()
        {
            return base.GetAll();
        }
    }
}
