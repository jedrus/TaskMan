using System.Runtime.Serialization;

namespace TaskMan.ServiceContracts.Data
{
    [DataContract]
    public enum TaskPriority
    {
        [EnumMember]
        Unset = 0,

        [EnumMember]
        Normal = 1,

        [EnumMember]
        High = 2,

        [EnumMember]
        Critical = 3
    }
}
