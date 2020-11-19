using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IEFRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetBy(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}