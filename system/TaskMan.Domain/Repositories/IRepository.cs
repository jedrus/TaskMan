using TaskMan.Domain.Entities;
using System.Collections.Generic;

namespace TaskMan.Domain.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Add(T entity);
        void Delete(T entity);
    }
}
