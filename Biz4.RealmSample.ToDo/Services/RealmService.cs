using System;
using System.Collections.Generic;
using System.Linq;
using Biz4.RealmSample.ToDo.Entities;
using Biz4.RealmSample.ToDo.Repositories;

namespace Biz4.RealmSample.ToDo.Services
{
    public class RealmService : ILocalService
    {


        public RealmService(IToDoRepository toDoRepository)
        {
            ToDoRepository = toDoRepository;
        }

        public IToDoRepository ToDoRepository { get; }

        public void CreateTask(ToDoItem toDoItem)
        {
            var input = new RlmToDoItem(toDoItem);
            ToDoRepository.Insert(input);
        }

        public IList<ToDoItem> GetTasks()
        {
            IQueryable<RlmToDoItem> tasks = ToDoRepository.GetAll();
            var r = tasks.OrderByDescending(_ => _.CreatedTime).ToList().Select(_ => new ToDoItem(_)).ToList();
            return r;
        }
    }
}