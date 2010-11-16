using System;
using TaskMan.DataAccess;
using System.Linq;
using TaskMan.Domain.Repositories;
using TaskMan.DataAccess.Repositories;
namespace TestConsole.Temporary
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: unit tests assembly, maybe based on nUnit ?

            ITaskRepository taskRepository = new TaskRepository(new TaskManContext());
            var tasks = taskRepository.GetAll();

            foreach (var task in tasks)
            {
                Console.WriteLine("Title: {0}", task.Title);
                Console.WriteLine("Author: {0}", task.Author.Login);
                Console.WriteLine("-------------------------------");
            }


            Console.ReadLine();

        }
    }
}
