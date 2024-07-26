

using Backend.Application.DTO;
using Backend.Application.Interfaces;
using Backend.Core.Entities;
using Backend.Core.Interfaces;


namespace Backend.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _repository;

        public ClientService(IClientRepository repository) 
        {
            _repository = repository;
        }
        public IEnumerable<ClientEntity> GetClients()
        {
            return _repository.GetClients();
        }
    }


}
