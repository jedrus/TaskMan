using System.Data.Objects;
using System.Linq;
using TaskMan.Domain.Repositories;
using TaskMan.Domain.Entities;

namespace TaskMan.DataAccess.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : EntityBase
    {
        private readonly ObjectContext _context;
        private readonly ObjectSet<T> _entity;

        protected RepositoryBase(ObjectContext context)
        {
            _context = context;
            _entity = _context.CreateObjectSet<T>();
        }

        private string GetEntityName()
        {
            return string.Format("{0}.{1}", _entity.EntitySet.EntityContainer, _entity.EntitySet.Name);
        }

        protected ObjectContext Context
        {
            get { return _context; }
        }

        protected IObjectSet<T> Entity
        {
            get { return _entity; }
        }

        public T GetById(int id)
        {
            string entityName = GetEntityName();
            var query = Context.CreateQuery<T>(entityName).Where(x => x.Id == id);
            return query.FirstOrDefault();
        }

        public System.Collections.Generic.IEnumerable<T> GetAll()
        {
            return Entity.AsEnumerable();
        }

        public T Add(T entity)
        {
            string entityName = GetEntityName();
            Context.AddObject(entityName, entity);
            Context.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);
            return entity;
        }

        public void Delete(T entity)
        {
            Context.DeleteObject(entity);
            Context.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);
        }
    }
}
