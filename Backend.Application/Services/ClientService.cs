
using AutoMapper;
using Backend.Apllication.DTO;
using Backend.Application.Interfaces;
using Backend.Core.Entities;
using Backend.Core.Interfaces;
using System.Data;
using System;
using System.Linq.Expressions;


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
            Expression<Func<ClientEntity, bool>> predicate = CreatePredicateGetAll(client.Email);

            var existClient = _repository.Search(predicate);
            foreach (var clientEntity in existClient) 
            {
                if (clientEntity.Email == client.Email) 
                {
                    throw new Exception("E-mail já está vinculado a outro Comprador;");
                }
            }

            var mapper = _mapper.Map<ClientEntity>(client);
            _repository.CreateClient(mapper);
        }

        public ClientDTO GetById(string id)
        {
            return _mapper.Map<ClientDTO>(_repository.GetById(id));
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

        private Expression<Func<ClientEntity, bool>> CreatePredicateGetAll(string email)
        {
            Expression<Func<ClientEntity, bool>> predicate = entidade => 
            entidade.Email != email && 
            entidade.DeletedFlag == false;
            return predicate;
        }
    }


}
