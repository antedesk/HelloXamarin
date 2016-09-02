using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin.Location
{
    public class LocationPoint
    {
        public LocationPoint(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }


        public double Latitude { private set; get; }
        public double Longitude { private set; get; }
        public override string ToString()
        {
            return String.Format("({0}, {1})", Latitude, Longitude);
        }


    }
}
