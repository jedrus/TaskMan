using System;
using System.Collections.Generic;

namespace TaskMan.Domain.Entities
{
    public class Task : EntityBase
    {
        protected Task()
        {
            AssignedUsers = System.Linq.Enumerable.Empty<User>();
        }

        public int AuthorId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime? RealisationDate { get; set; }

        public TaskPriority Priority { get; set; }

        public IEnumerable<User> AssignedUsers { get; set; }

    }
}
