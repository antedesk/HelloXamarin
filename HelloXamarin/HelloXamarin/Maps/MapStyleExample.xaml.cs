using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace HelloXamarin.Maps
{
    public partial class MapStyleExample : ContentPage
    {

        const double InitialLongitudeSpan = 48;
        const double InitialZoom = 0;

        public MapStyleExample()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            Position center = map.VisibleRegion.Center;
            double longitudeSpan = InitialLongitudeSpan * Math.Pow(2, InitialZoom - args.NewValue);
            map.MoveToRegion(new MapSpan(center, 0, longitudeSpan));
        }

        void HandleClicked(object sender, EventArgs e)
        {
            var b = sender as Button;
            switch (b.Text)
            {
                case "Street":
                    map.MapType = MapType.Street;
                    break;
                case "Hybrid":
                    map.MapType = MapType.Hybrid;
                    break;
                case "Satellite":
                    map.MapType = MapType.Satellite;
                    break;
            }
        }
    }
}
