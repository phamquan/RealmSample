using System;
using System.Windows.Input;
using Biz4.Core.Framework.ViewModels;
using Biz4.RealmSample.ToDo.Entities;
using Biz4.RealmSample.ToDo.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace Biz4.RealmSample.ToDo.ViewModels
{
    public class AddItemPageViewModel : ViewModelBase
    {

        public string TaskTitle { get; set; }
        public string TaskContent { get; set; }
        public ICommand AddCommand { get; }
        public ILocalService LocalService { get; }
        public IPageDialogService PageDialogService { get; }

        private async void OnAddCommandExecuted()
        {
            if (string.IsNullOrEmpty(TaskTitle) || string.IsNullOrEmpty(TaskContent))
            {
                await this.PageDialogService.DisplayAlertAsync("Warning", "Enter both", "OK");
                return;
            }

            ToDoItem toDoItem = new ToDoItem()
            {
                Title = TaskTitle,
                Content = TaskContent,
                CreatedTime = DateTime.Now
            };

            LocalService.CreateTask(toDoItem);

            await this.NavigationService.GoBackAsync();
        }

        public AddItemPageViewModel(INavigationService navigationService,
            ILocalService localService,
            IPageDialogService pageDialogService
        ) : base(navigationService)
        {
            LocalService = localService;
            PageDialogService = pageDialogService;

            AddCommand = new DelegateCommand(OnAddCommandExecuted);
        }
    }
}
