using System;
using Prism.Mvvm;
using Biz4.RealmSample.ToDo.Resources;

namespace Biz4.RealmSample.ToDo.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public ViewAViewModel()
        {
            Title = AppResources.ViewATitle;
        }

        public string Title { get; set; }
    }
}