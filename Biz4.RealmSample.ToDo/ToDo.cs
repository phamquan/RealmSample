using Plugin.Multilingual;
using Biz4.RealmSample.ToDo.Resources;
using Prism.Ioc;
using Prism.Modularity;
using Xamarin.Forms;
using Biz4.RealmSample.ToDo.Views;
using Biz4.RealmSample.ToDo.ViewModels;

namespace Biz4.RealmSample.ToDo
{
    public class ToDo : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // Handle post initialization tasks like resolving IEventAggregator to subscribe events
            AppResources.Culture = CrossMultilingual.Current.DeviceCultureInfo;
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ToDoList, ToDoListViewModel>();
        }
    }
}