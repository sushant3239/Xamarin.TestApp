using System;
using AppName.Core.ApplicationServices;

namespace TestApp.Infrastructure
{
    public class NavigationService : INavigationService
    {
        public void ShowView(string viewName, object navigtaionParameter = null)
        {
            switch (viewName)
            {
                case "SecondView":
                    App.Current.MainPage.Navigation.PushAsync(new SecondPage(navigtaionParameter));
                    break;
            }
        }
    }
}
