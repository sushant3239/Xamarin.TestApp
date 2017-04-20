using System;
using AppName.Core.ApplicationServices;
using AppName.Core.Model;

namespace TestApp.UWP.ApplicationServices
{
    public class LocationService : ILocationService
    {
        public LocationData GetLocation()
        {
            return new LocationData(124.244, 1234.344);
        }
    }
}
