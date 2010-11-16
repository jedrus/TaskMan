using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using TaskMan.Domain.Repositories;

namespace TaskMan.DataAccess.Repositories
{
    public class TaskRepository : RepositoryBase<Domain.Entities.Task>, ITaskRepository
    {
        public TaskRepository(ObjectContext context) : base(context)
        {

        }

        public IEnumerable<Domain.Entities.Task> GetUserTasks(int userId)
        {
            return Entity.Where(x => x.Author.Id == userId).AsEnumerable();
        }
    }
}
