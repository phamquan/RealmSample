using System;
using Prism.Mvvm;
using Biz4.RealmSample.ToDo.Resources;
using Prism.Navigation;
using Biz4.Core.Framework.ViewModels;

namespace Biz4.RealmSample.ToDo.ViewModels
{
    public class ToDoListViewModel : ViewModelBase
    {
        public ToDoListViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = AppResources.ViewATitle;
        }

        public string Title { get; set; }
    }
}