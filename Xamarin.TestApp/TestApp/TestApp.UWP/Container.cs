using AppName.Core.ApplicationServices;
using AppName.Core.ViewModel;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Infrastructure;
using TestApp.UWP.ApplicationServices;

namespace TestApp.UWP
{
    public static class Container
    {
        private static UnityContainer _unity;

        internal static void Intialize()
        {
            _unity =  new UnityContainer();
            RegisterTypes();
        }

        private static void RegisterTypes()
        {
            _unity.RegisterType<ILocationService, LocationService>();
            _unity.RegisterType<FirstViewModel, FirstViewModel>();
            _unity.RegisterType<SecondViewModel, SecondViewModel>();
            _unity.RegisterType<INavigationService, NavigationService>();
        }

        public static T Resolve<T>()
        {
            return _unity.Resolve<T>();
        }
    }
}
