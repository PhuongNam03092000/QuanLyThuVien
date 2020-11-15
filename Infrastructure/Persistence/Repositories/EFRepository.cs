using Domain.Common;
using Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Persistence.Repositories
{
    public class EFRepository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        protected readonly QLTVContext context;

        public EFRepository(QLTVContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetBy(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}