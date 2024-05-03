using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Location
    {
        public DateTime Date { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public Location(double latitude, double longitude)
        {
            // Constructor implementation
        }
    }

    public class PathManager
    {
        private List<Location> locations;

        public PathManager()
        {
            locations = new List<Location>();
        }

        public void AddLocation(Location location)
        {
            locations.Add(location);
        }

        public void RemoveLocation(Location location)
        {
            locations.Remove(location);
        }
    }
}
