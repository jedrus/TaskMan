using System.Collections.Generic;
using System.ServiceModel;
using TaskMan.ServiceContracts.Data;

namespace TaskMan.ServiceContracts.Services
{
    [ServiceContract(Namespace = "http://taskman/taskservices/")]
    public interface ITaskService
    {
        [OperationContract]
        TaskDto CreateNewTask(TaskDto task);

        [OperationContract]
        TaskDto GetById(int id);

        [OperationContract]
        TaskDto UpdateTask(TaskDto task);

        [OperationContract]
        IList<TaskDto> GetAllForUser(int userId);
    }
}
