using System;
using Realms;

namespace Biz4.RealmSample.ToDo.Entities
{
    public class ToDoItem
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreatedTime { get; set; }

        public ToDoItem(RlmToDoItem toDoItem)
        {
            Title = toDoItem.Title;
            Content = toDoItem.Content;
            CreatedTime = toDoItem.CreatedTime;
        }

        public ToDoItem()
        {
        }
    }

    public class RlmToDoItem : RealmObject
    {

        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreatedTime { get; set; }

        public RlmToDoItem()
        {

        }

        public RlmToDoItem(ToDoItem toDoItem)
        {
            Title = toDoItem.Title;
            Content = toDoItem.Content;
            CreatedTime = toDoItem.CreatedTime;
        }
    }
}
