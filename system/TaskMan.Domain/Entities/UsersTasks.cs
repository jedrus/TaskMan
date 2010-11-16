namespace TaskMan.Domain.Entities
{
    public class UsersTask : EntityBase
    {
        public int UserId { get; set; }
        public int TaskId { get; set; }

        public virtual User User { get; set; }
    }
}
