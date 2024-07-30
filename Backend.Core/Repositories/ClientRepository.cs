using Backend.Core.Entities;
using Backend.Core.Interfaces;
using Backend.Domain.Base;
using Backend.Domain.Connection;
using System.Linq.Expressions;

namespace Backend.Core.Repositories
{
    public class ClientRepository : NoSqlRepository<ClientEntity>, IClientRepository
    {
        public ClientRepository(IDatabaseSettings settings) : base(settings) { }

        public void CreateClient(ClientEntity client)
        {
            base.Save(client);
        }

        public List<ClientEntity> GetClients()
        {
            return base.GetAll().ToList();
        }

        public void UpdateClient(ClientEntity client)
        {
            base.Update(client);
        }

        public ClientEntity GetById(string id)
        {
            return base.GetById(id);
        }

        public List<ClientEntity> Search(Expression<Func<ClientEntity, bool>> predicate)
        {
            return base.Search(predicate).ToList();
        }
    }
}
