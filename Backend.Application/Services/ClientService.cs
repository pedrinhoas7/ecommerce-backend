
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
            //TODO: Adicionar funcionalidade em utils
            // Hash Password
            client.Password = BCrypt.Net.BCrypt.HashPassword(
                client.Password,
                BCrypt.Net.BCrypt.GenerateSalt(10)
                );

            //Save User
            _repository.CreateClient(
                _mapper.Map<ClientEntity>(client)
                );

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

        public bool VerifyRegister(VerifyClientDTO search)
        {
            var existRegister = false;

            var predicate = CreatePredicate(search.Field, search.Value);
            var clients = _repository.Search(predicate).ToList();

            if (clients.Any())
                existRegister = true;

            return existRegister;
        }

        private Expression<Func<ClientEntity, bool>> CreatePredicate(string field,string value)
        {

            if (field == "email")
            {
                Expression<Func<ClientEntity, bool>> search = entidade => entidade.Email == value && entidade.DeletedFlag == false;
                return search;
            }

            if (field == "documentIdentifier")
            {
                Expression<Func<ClientEntity, bool>> search = entidade => entidade.DocumentIdentifier == value && entidade.DeletedFlag == false;
                return search;
            }

            if (field == "inscricaoEstadual")
            {
                Expression<Func<ClientEntity, bool>> search = entidade => entidade.InscricaoEstadual == value && entidade.DeletedFlag == false;
                return search;
            }

            throw new Exception($"Field: {field} not exist.");
        }

    }


}
