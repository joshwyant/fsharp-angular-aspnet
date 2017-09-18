using Crud.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data
{
    abstract class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        protected ICrudDataContext context { get; private set; }

        protected EntityRepository(ICrudDataContext context)
        {
            this.context = context;
        }

        public void Add(TEntity item)
        {
            context.Set<TEntity>().Add(item);
        }

        public void AddRange(IEnumerable<TEntity> items)
        {
            context.Set<TEntity>().AddRange(items);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).ToList();
        }

        public TEntity Find(int id)
        {
            return context.Set<TEntity>().SingleOrDefault(e => e.Id == id);
        }

        public void Remove(TEntity item)
        {
            context.Set<TEntity>().Remove(item);
        }

        public void RemoveRange(IEnumerable<TEntity> items)
        {
            context.Set<TEntity>().RemoveRange(items);
        }
    }
}
