using HelloXamarin.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace HelloXamarin.Maps
{
    public partial class MapLocationPOIExample : ContentPage
    {
        const double InitialLongitudeSpan = 48;
        const double InitialZoom = 15;

        ILocationProvider locManager;
        Position position;

        public MapLocationPOIExample()
        {
            InitializeComponent();
            map.MoveToRegion(new MapSpan(new Position(41.9027835, 12.496365500000024), 0, InitialLongitudeSpan));

            if (Device.OS != TargetPlatform.Android)
            {
                locManager = DependencyService.Get<ILocationProvider>();
                locManager.LocationChanged += OnLocationTracker;
            }

            LoadPinsOnMap();

        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Device.OS != TargetPlatform.Android)
            {
                locManager.StartAcquisition();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (Device.OS != TargetPlatform.Android)
            {
                locManager.StopAcquisition();
            }
        }



        void OnLocationTracker(object sender, LocationPoint args)
        {
            position = new Position(args.Latitude, args.Longitude); 
        }


        public List<POI> CreatePOIs()
        {
            POI poi1 = new POI("Colosseo", " Piazza del Colosseo, Roma, RM, Italia", new LocationPoint(41.8902102, 12.492230899999981));
            POI poi2 = new POI("Città del Vaticano", "00120 Città del Vaticano", new LocationPoint(41.9021788, 12.453600700000038));
            POI poi3 = new POI("Piazza di Spagna", "Piazza di Spagna, Roma, RM, Italia", new LocationPoint(41.9056978, 12.482326999999941));

            List<POI> POIs = new List<POI>()
            {
                poi1, poi2, poi3
            };

            return POIs;
        }

        public void LoadPinsOnMap()
        {
            List<POI> POIsList = CreatePOIs();
            foreach (POI poi in POIsList)
            {
                Pin pin = new Pin
                {
                    BindingContext = poi,
                    Label = poi.Name,
                    Position = new Position(poi.Coordinates.Latitude, poi.Coordinates.Longitude),
                    Address = poi.Address
                };
                
                map.Pins.Add(pin);
            }
        }

    }
}
