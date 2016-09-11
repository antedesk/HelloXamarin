using HelloXamarin.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin.Maps
{
    public class POI
    {

        public POI(string name, string address, LocationPoint coordinates)
        {
            Name = name;
            Address = address;
            Coordinates = coordinates;
        }
        
        public string Name { get; set; }

        public string Address { get; set; }

        public LocationPoint Coordinates { get; set; }

    }
}
