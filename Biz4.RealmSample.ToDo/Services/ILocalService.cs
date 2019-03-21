using System;
using System.Collections.Generic;
using Biz4.RealmSample.ToDo.Entities;

namespace Biz4.RealmSample.ToDo.Services
{
    public interface ILocalService
    {
        void CreateTask(ToDoItem toDoItem);
        IList<ToDoItem> GetTasks();
    }
}