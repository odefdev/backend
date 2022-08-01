

using Infraestructura.Data;
using Repository.Repository;
using System.Linq.Expressions;

namespace Repository.RepositoryImpl
{
    public class RepositoryImpl<TEntity> : BaseRepository,IRepository<TEntity> where TEntity : class
    {
        public RepositoryImpl(ApplicationDbContext context) : base(context)
        {
        }

        public void Add(TEntity entity)
        {
           this.dbContext.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            this.dbContext.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this.dbContext.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return this.dbContext.Set<TEntity>().Find(id)!;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.dbContext.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            this.dbContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            this.dbContext.Set<TEntity>().RemoveRange(entities);
        }
    }
}
