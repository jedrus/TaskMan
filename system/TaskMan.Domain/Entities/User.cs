namespace TaskMan.Domain.Entities
{
    public class User : EntityBase
    {
        public string Login { get; set; }
        public string Password { get; set; }

        protected User() { }
    }
}
