
using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.Repositories
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IEnumerable<T> GetAll();
        T GetBy(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
