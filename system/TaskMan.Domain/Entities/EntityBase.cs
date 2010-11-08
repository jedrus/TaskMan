namespace TaskMan.Domain.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; protected set; }
    }
}
