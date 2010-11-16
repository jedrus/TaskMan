using System.Data.Objects;
using TaskMan.Domain.Entities;

namespace TaskMan.DataAccess
{
    public class TaskManContext : ObjectContext
    {
        private readonly ObjectSet<User> _users;

        public ObjectSet<User> Users
        {
            get
            {
                return _users;
            }
        }


        private readonly ObjectSet<Task> _tasks;

        public ObjectSet<Task> Tasks
        {
            get
            {
                return _tasks;
            }
        }
        

        public TaskManContext() : base("name=TaskManEntities", "TaskManEntities")
        {
            ContextOptions.LazyLoadingEnabled = true;

            _users = CreateObjectSet<User>();
            _tasks = CreateObjectSet<Task>();
        }
    }
}
