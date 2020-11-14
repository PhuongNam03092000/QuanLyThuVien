using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
