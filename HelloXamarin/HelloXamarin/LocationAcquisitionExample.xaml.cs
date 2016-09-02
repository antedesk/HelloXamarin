using HelloXamarin.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class LocationAcquisitionExample : ContentPage
    {
        LocationPoint currLocation;

        public LocationAcquisitionExample()
        {
            InitializeComponent();

            ILocationProvider locationProvider = DependencyService.Get<ILocationProvider>();
            locationProvider.LocationChanged += OnLocationProviderLocationChanged;
            locationProvider.StartAcquisition();
        }


        void OnLocationProviderLocationChanged(object sender, LocationPoint args)
        {
            LatitudeText.Text = String.Format("{0}", args.Latitude);
            LongitudeText.Text = String.Format("{0}", args.Longitude);

            // Update dot on map.
            currLocation = args;
        }
        
    }
}
