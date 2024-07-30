using Backend.Apllication.DTO;
using Backend.Core.Entities;


namespace Backend.Application.Interfaces
{
    public interface IClientService
    {
        void CreateClient(ClientDTO client);
        List<ClientDTO> GetClients();
        void UpdateClient(string id, ClientDTO client);
    }
}
