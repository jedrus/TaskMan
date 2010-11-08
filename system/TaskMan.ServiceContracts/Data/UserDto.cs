using System.Runtime.Serialization;

namespace TaskMan.ServiceContracts.Data
{
    [DataContract]
    public class UserDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
