using System;
using Prism.Mvvm;

namespace Biz4.RealmSample.ToDo.ViewModels
{
    public class ToDoListItemViewModel : BindableBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
