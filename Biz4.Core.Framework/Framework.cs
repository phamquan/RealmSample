using Prism.Ioc;
using Prism.Modularity;
//using Biz4.Core.Framework.Views;
using Biz4.Core.Framework.ViewModels;

namespace Biz4.Core.Framework
{
    public class Framework : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
