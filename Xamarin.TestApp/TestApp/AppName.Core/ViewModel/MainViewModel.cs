using AppName.Core.ApplicationServices;
using AppName.Core.Infrastructure.Commands;
using System.Windows.Input;
using System;
using AppName.Core.Model;

namespace AppName.Core.ViewModel
{
    public class MainViewModel
    {
        private readonly ILocationService _locationService;
        private readonly INavigationService _navigationService;

        public MainViewModel(ILocationService locationService, FirstViewModel first, SecondViewModel second, INavigationService navigationService)
        {
            _locationService = locationService;
            this.FirstViewModel = first;
            this.SecondViewModel = second;
            Location = _locationService.GetLocation();
            _navigationService = navigationService;
        }

        public ICommand FetchLocationDataCommand { get { return new TestCommand(FetchLocationData); } }
        public ICommand NavigationToSecondPageCommand { get { return new TestCommand(NavigateToSecond); }  }

        private void NavigateToSecond(object obj)
        {
            _navigationService.ShowView("SecondView", Location);
        }

        public LocationData FetchLocation { get; private set; }
        public FirstViewModel FirstViewModel { get; private set; }
        public SecondViewModel SecondViewModel { get; private set; }
        public LocationData Location { get; private set; }

        private void FetchLocationData(object obj)
        {
            FetchLocation = _locationService.GetLocation();
        }
        
    }    
}
