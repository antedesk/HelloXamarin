using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CoreLocation;
using Xamarin.Forms;
using HelloXamarin.Location;
using UIKit;

[assembly: Dependency(typeof(Xamarin.FormsBook.Platform.iOS.LocationProvider_iOS))]

namespace Xamarin.FormsBook.Platform.iOS
{
    public class LocationProvider_iOS : ILocationProvider
    {
        CLLocationManager locationManager;

        public event EventHandler<LocationPoint> LocationChanged;

        public LocationProvider_iOS()
        {
            locationManager = new CLLocationManager();

            // Autorizzazione richiesta a partire da iOS 8
            if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
            {
                locationManager.RequestWhenInUseAuthorization();
            }

            locationManager.LocationsUpdated +=
                (object sender, CLLocationsUpdatedEventArgs args) =>
                {
                    CLLocationCoordinate2D coordinate = args.Locations[0].Coordinate;
                    EventHandler<LocationPoint> handler = LocationChanged;

                    if (handler != null)
                    {
                        handler(this, new LocationPoint(coordinate.Latitude, coordinate.Longitude));
                    }
                };
        }
        public void StartAcquisition()
        {
            if (CLLocationManager.LocationServicesEnabled)
            {
                locationManager.StartUpdatingLocation();
            }
        }

        public void StopAcquisition()
        {
            locationManager.StopUpdatingLocation();
        }
    }
}