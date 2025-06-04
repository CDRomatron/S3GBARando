using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3GBARandoApp
{
    public class Location
    {
        public int id;
        public LocationType type;
        public int address;
        public string addressString;
        public Location(int Id, LocationType Type, int Address) {
            id = Id;
            type = Type;
            address = Address;
            addressString = Address.ToString("X8");
        }
    }

    public enum LocationType {
        Free = 0,
        Red = 1,
        Green = 2,
        Purple = 3,
        Yellow = 4,
        NPC = 5,
        Byrd = 6,
        Agent = 7
    }
}
