using System;
using Prism.Mvvm;
using Biz4.RealmSample.ToDo.Resources;
using Prism.Navigation;
using Biz4.Core.Framework.ViewModels;
using Biz4.RealmSample.ToDo.Services;
using Biz4.RealmSample.ToDo.Entities;
using System.Windows.Input;
using Prism.Commands;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Linq;

namespace Biz4.RealmSample.ToDo.ViewModels
{
    public class ToDoListPageViewModel : ViewModelBase
    {
        public RangedObservableCollection<ToDoListItemViewModel> Tasks { get; set; }


        public ICommand AddCommand { get; set; }

        public ToDoListPageViewModel(INavigationService navigationService,
            RealmService realmService
        )
            : base(navigationService)
        {
            Title = AppResources.ViewATitle;
            RealmService = realmService;

            Tasks = new RangedObservableCollection<ToDoListItemViewModel>();
            AddCommand = new DelegateCommand(AddTask);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            LoadTask();
        }

        public string Title { get; set; }
        public RealmService RealmService { get; }

        public void LoadTask()
        {
            var a = RealmService.GetTasks();
            Tasks.ReplaceRange(a.Select(_ => new ToDoListItemViewModel
            {
                Title = _.Title,
                Content = _.Content
            }));

        }

        public void AddTask()
        {
            this.NavigationService.NavigateAsync("AddItemPage");
        }
    }
}