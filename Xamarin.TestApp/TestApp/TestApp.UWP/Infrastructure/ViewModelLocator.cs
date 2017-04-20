using AppName.Core.Infrastructure;
using AppName.Core.ViewModel;
using TestApp.UWP.ApplicationServices;

namespace TestApp.UWP.Infrastructure
{
    public class ViewModelLocator : IViewModelLocator
    {       
        public T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
