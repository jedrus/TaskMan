using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TaskMan.ServiceContracts.Data
{
    [DataContract]
    public class TaskDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int AuthorId { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public DateTime? RealisationDate { get; set; }

        [DataMember]
        public TaskPriority Priority { get; set; }

        [DataMember]
        public IEnumerable<UserDto> AssignedUsers { get; set; }

        public TaskDto()
        {
            AssignedUsers = System.Linq.Enumerable.Empty<UserDto>();
        }
    }
}
