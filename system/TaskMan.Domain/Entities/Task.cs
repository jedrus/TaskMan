using System;
using System.Collections.Generic;

namespace TaskMan.Domain.Entities
{
    public class Task : EntityBase
    {
        protected Task()
        {
            
        }

        public int AuthorId { get; set; }

        public virtual User Author { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime? RealisationDate { get; set; }

        public int PriorityValue { get; set; }

        public TaskPriority Priority
        {
            get { return (TaskPriority) PriorityValue; }
            set { PriorityValue = (int) value; }
        }

        public virtual IList<UsersTask> AssignedUsers { get; set; }

    }
}
