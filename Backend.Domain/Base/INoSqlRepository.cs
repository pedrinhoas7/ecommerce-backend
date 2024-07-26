using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Base
{
    public interface INoSqlRepository<TEntity> where TEntity : EntityNoSql, new()
    {

        TEntity Save(TEntity entity);

        void Update(TEntity entity);

        TEntity GetById(string id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);

        void Delete(TEntity entity);

    }
}
