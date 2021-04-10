using System;
using System.Collections.Generic;
using System.Text;

namespace _6___This_and_Base
{
    class GeoPoint
    {

        public string name;
        public double lat;
        public double lon;

        public void SetCoordinates(double lat, double lon)
        {
            this.lat = lat;
            this.lon = lon;
        }

        public override string ToString()
        {
            //Acessa variável pertencente ao objeto em si
            return "(" + this.lat + "," + this.lon + ")";
        }
    }
}