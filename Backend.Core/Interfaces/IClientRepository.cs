using Backend.Core.Entities;

namespace Backend.Core.Interfaces
{
    public interface IClientRepository
    {
        IEnumerable<ClientEntity> GetClients();
    }
}
