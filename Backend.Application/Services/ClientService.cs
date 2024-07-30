
using AutoMapper;
using Backend.Apllication.DTO;
using Backend.Application.Interfaces;
using Backend.Core.Entities;
using Backend.Core.Interfaces;


namespace Backend.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _repository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void CreateClient(ClientDTO client)
        {
            var mapper = _mapper.Map<ClientEntity>(client);
            _repository.CreateClient(mapper);
        }

        public List<ClientDTO> GetClients()
        {
            var mapper = _repository.GetClients();
            return _mapper.Map<List<ClientDTO>>(mapper);
        }

        public void UpdateClient(string id, ClientDTO client)
        {
            var mapper = _mapper.Map<ClientEntity>(client); 
            var entity = _repository.GetById(id);
            client.Id = entity.Id;
            _repository.UpdateClient(mapper);
        }
    }


}
