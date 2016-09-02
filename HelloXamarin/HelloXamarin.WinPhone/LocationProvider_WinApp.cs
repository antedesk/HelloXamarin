using HelloXamarin.Location;
using HelloXamarin.WinPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Xamarin.Forms;

[assembly: Dependency(typeof(LocationProvider_WinApp))]

namespace HelloXamarin.WinPhone
{
    public class LocationProvider_WinApp : ILocationProvider
    {
        public Geolocator glocator;
        public event EventHandler<LocationPoint> LocationChanged;

        public LocationProvider_WinApp()
        {
            glocator = new Geolocator();
            glocator.ReportInterval = 1000;
        }

        public void StartAcquisition()
        {
            glocator.PositionChanged += OnGeolocatorPositionChanged;
        }

        public void StopAcquisition()
        {
            glocator.PositionChanged -= OnGeolocatorPositionChanged;
        }

        public void OnGeolocatorPositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            BasicGeoposition coordinate = args.Position.Coordinate.Point.Position;

            Device.BeginInvokeOnMainThread(() =>
            {
                EventHandler<LocationPoint> handler = LocationChanged;

                if (handler != null)
                {
                    handler(this, new LocationPoint(coordinate.Latitude, coordinate.Longitude));
                }
            });
        }

    }
}
