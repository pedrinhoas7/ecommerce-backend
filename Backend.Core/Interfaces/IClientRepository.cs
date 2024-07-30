using Backend.Core.Entities;
using System.Linq.Expressions;

namespace Backend.Core.Interfaces
{
    public interface IClientRepository
    {
        void CreateClient(ClientEntity client);
        List<ClientEntity> GetClients();
        void UpdateClient(ClientEntity client);
        ClientEntity GetById(string id);
        List<ClientEntity> Search(Expression<Func<ClientEntity, bool>> predicate);

    }
}
