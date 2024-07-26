using Backend.Domain.Connection;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization;
using Backend.Domain.Atributes;
using System.Linq.Expressions;
using MongoDB.Driver;


namespace Backend.Domain.Base
{
    public class NoSqlRepository<TEntity> : INoSqlRepository<TEntity> where TEntity : EntityNoSql, new()
    {
        protected readonly IMongoCollection<TEntity> _Entity;

        public NoSqlRepository(IDatabaseSettings settings)
        {
            var pack = new ConventionPack();
            pack.Add(new IgnoreExtraElementsConvention(true));
            ConventionRegistry.Register("ignoreExtra", pack, t => true);
            var classe = typeof(TEntity);
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            var documentName = (Document[])classe.GetCustomAttributes(typeof(Document), true);
            if (documentName[0] != null && documentName[0].Value != null)
            {
                _Entity = database.GetCollection<TEntity>(documentName[0].Value);
            }
            else
            {
                _Entity = database.GetCollection<TEntity>(classe.Name);
            }
        }

        public virtual void Delete(TEntity entity)
        {
            entity.LastUpdateDate = DateTime.Now;
            entity.DeletedFlag = true;
            this.Update(entity);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return this._Entity.AsQueryable().Where(entidade => entidade.DeletedFlag == false);
        }

        public virtual IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate != null)
            {
                var result = _Entity.AsQueryable().Where(entitdade => entitdade.DeletedFlag == false).Where(predicate);

                return result;
            }

            return _Entity.AsQueryable().Where(entitdade => entitdade.DeletedFlag == false);
        }

        public virtual TEntity GetById(string id)
        {
            return this._Entity.Find(entidade => entidade.Id == id && entidade.DeletedFlag == false).FirstOrDefault();
        }

        public virtual TEntity Save(TEntity entity)
        {
            entity.CreationDate = DateTime.Now;
            this._Entity.InsertOne(entity);
            return entity;
        }

        public virtual void Update(TEntity entity)
        {
            entity.LastUpdateDate = DateTime.Now;
            this._Entity.ReplaceOne(entidade => entidade.Id == entity.Id, entity);
        }
    }
}
