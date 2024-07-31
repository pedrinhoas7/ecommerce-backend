using Backend.Core.Entities;
using Backend.Core.Interfaces;
using Backend.Domain.Base;
using Backend.Domain.Connection;
using MongoDB.Driver;
using SharpCompress.Common;
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
            //TODO: Add Builders Project para excluir somente o campo específico
            return base.GetAll().Select(entity => new ClientEntity()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                BirthDate = entity.BirthDate,
                DocumentIdentifier = entity.DocumentIdentifier,
                DocumentName = entity.DocumentName,
                CreationDate = entity.CreationDate,
                InscricaoEstadual = entity.InscricaoEstadual,
                IsBlocked = entity.IsBlocked,
                LastUpdateDate = entity.LastUpdateDate,
                TypeClient = entity.TypeClient,
                TypeGender = entity.TypeGender,
                DeletedFlag = entity.DeletedFlag, 
                
            }).ToList();
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
