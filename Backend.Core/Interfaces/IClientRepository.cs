using Backend.Core.Entities;

namespace Backend.Core.Interfaces
{
    public interface IClientRepository
    {
        void CreateClient(ClientEntity client);
        List<ClientEntity> GetClients();
        void UpdateClient(ClientEntity client);
        ClientEntity GetById(string id);
    }
}
