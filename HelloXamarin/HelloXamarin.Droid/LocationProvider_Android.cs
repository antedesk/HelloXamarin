using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using HelloXamarin.Droid;
using Xamarin.Forms;
using HelloXamarin.Location;
using Android.Locations;

[assembly: Dependency(typeof(LocationProvider_Android))]

namespace HelloXamarin.Droid
{
    public class LocationProvider_Android :  Java.Lang.Object, ILocationProvider, ILocationListener
    {
        LocationManager locationManager;

        public event EventHandler<LocationPoint> LocationChanged;

        public LocationProvider_Android()
        {
            Activity activity = LocalizationSupport.Activity;

            if (activity == null)
                throw new InvalidOperationException(
                    "Must call Toolkit.Init before using LocationProvider");

            locationManager =
                activity.GetSystemService(Context.LocationService) as LocationManager;
        }

        // Two methods to implement ILocationProvider (the dependency service interface).
        public void StartAcquisition()
        {
            IList<string> locationProviders = locationManager.AllProviders;

            foreach (string locationProvider in locationProviders)
            {
                locationManager.RequestLocationUpdates(locationProvider, 1000, 1, this);
            }
        }

        public void StopAcquisition()
        {
            locationManager.RemoveUpdates(this);
        }


        // i successivi 4 metodi sono dell'interfaccia ILocationListener 
        public void OnLocationChanged(Android.Locations.Location location)
        {
            EventHandler<LocationPoint> handler = LocationChanged;

            if (handler != null)
            {
                handler(this, new LocationPoint(location.Latitude, location.Longitude));
            }
        }

        public void OnProviderDisabled(string provider)
        {
        }

        public void OnProviderEnabled(string provider)
        {
        }

        public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras)
        {
        }
    }
 }