using System.Collections.Generic;
using TaskMan.Domain.Entities;

namespace TaskMan.Domain.Repositories
{
    public interface ITaskRepository : IRepository<Task>
    {
        IEnumerable<Task> GetUserTasks(int userId);
    }
}
