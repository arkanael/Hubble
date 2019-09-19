using System;
using System.Collections.Generic;

namespace Hubble.Data.Repositories.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity: class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> Find();
        TEntity Find(int id);
    }
}
