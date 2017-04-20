namespace AppName.Core.Model
{
    public class LocationData
    {
        public LocationData(double lat, double longitude)
        {
            Latitude = lat;
            Longitude = longitude;
        }

        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
    }
}
