using Hubble.Data.Context;
using Hubble.Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Hubble.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DataContext dataContext;

        protected BaseRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Insert(TEntity entity)
        {
            dataContext.Entry(entity).State = EntityState.Added;
            dataContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            dataContext.Entry(entity).State = EntityState.Modified;
            dataContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            dataContext.Entry(entity).State = EntityState.Deleted;
            dataContext.SaveChanges();
        }

        public List<TEntity> Find()
        {
            return dataContext.Set<TEntity>().ToList();
        }

        public TEntity Find(int id)
        {
            return dataContext.Set<TEntity>().Find(id);
        }

        public void Dispose()
        {
            dataContext.Dispose();
        }
    }
}
