using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3GBARandoApp
{
    internal static class Data
    {
        public static List<Location> DefaultLocations()
        {
            List<Location> locations = new List<Location>
            {
                // Dragon Shores
                new Location(0x43, LocationType.Free, 0x0025BED5), // Dragon Star
                new Location(0x44, LocationType.Green, 0x002696F4), // The Roo Zetta Stone
                new Location(0x45, LocationType.NPC, 0x00636EEC), // Heart of the Dragon Shores
                new Location(0x46, LocationType.NPC, 0x00637A77), // Spyro Action Figure
                //new Location(0x47, LocationType.Free, ); -- Boss
                new Location(0x48, LocationType.NPC, 0x0063868D), // Extenso-Grip Attachment
                new Location(0x49, LocationType.Byrd, 0x006372FF), // Left Half of the Green Chest Key
                new Location(0x4A, LocationType.NPC, 0x0063895F), // Book-B-Gone Storage Unit

                // Fairy Library
                new Location(0x4B, LocationType.Green, 0x00275C13),
                new Location(0x4C, LocationType.Purple, 0x00275D7B),
                new Location(0x4D, LocationType.NPC, 0x00637646),
                new Location(0x4E, LocationType.NPC, 0x0063770E),
                new Location(0x4F, LocationType.NPC, 0x006375A7),
                new Location(0x50, LocationType.Free, 0x002A918E),
                //locations.Add(new Location(0x51, LocationType.Free, )); -- Boss
                new Location(0x52, LocationType.Red, 0x00275E3A),

                // Yeti Serengeti
                new Location(0x53, LocationType.Free, 0x00226959),
                //new Location(0x54, LocationType.NPC, 0x00638B83),
                new Location(0x55, LocationType.Free, 0x00226A6A),
                new Location(0x56, LocationType.NPC, 0x00638B31),
                new Location(0x57, LocationType.Free, 0x002AF652),
                new Location(0x58, LocationType.Free, 0x002FEF12),
                new Location(0x59, LocationType.Red, 0x00226A72),
                new Location(0x5A, LocationType.Purple, 0x00226A7A),

                // Byrd Barracks
                new Location(0x5B, LocationType.Free, 0x002E6FDD),
                new Location(0x5C, LocationType.NPC, 0x00637E6C),
                new Location(0x5D, LocationType.NPC, 0x00637DC7),
                new Location(0x5E, LocationType.NPC, 0x00637F4E),
                new Location(0x5F, LocationType.Free, 0x002ADEBD),
                new Location(0x60, LocationType.NPC, 0x00637E12),
                new Location(0x61, LocationType.Byrd, 0x00637225),
                new Location(0x62, LocationType.Red, 0x002E711D),

                // Thieves Guild
                new Location(0x63, LocationType.Purple, 0x002F6A24),
                new Location(0x64, LocationType.NPC, 0x006388C3),
                new Location(0x65, LocationType.NPC, 0x00637819),
                new Location(0x66, LocationType.NPC, 0x0063856F),
                new Location(0x67, LocationType.Free, 0x002AE874),
                new Location(0x68, LocationType.NPC, 0x00638596),
                new Location(0x69, LocationType.Agent, 0x00637105),
                new Location(0x6A, LocationType.NPC, 0x0063795F),

                // Rabbit Habitat
                new Location(0x6B, LocationType.Purple, 0x002CB923),
                new Location(0x6C, LocationType.NPC, 0x00638A2D),
                new Location(0x6D, LocationType.NPC, 0x00636C0A),
                new Location(0x6E, LocationType.Free, 0x002AD17E),
                //new Location(0x6F, LocationType.NPC, 0x00637B93),
                new Location(0x70, LocationType.Red, 0x002CB914),
                new Location(0x71, LocationType.Red, 0x002CB91B),
                new Location(0x72, LocationType.Yellow, 0x002CB92B),

                // Banana Savannah
                new Location(0x73, LocationType.Green, 0x0021D819),
                new Location(0x74, LocationType.Free, 0x0021D58C),
                new Location(0x75, LocationType.NPC, 0x00637C81),
                new Location(0x76, LocationType.NPC, 0x00637D30),
                new Location(0x77, LocationType.NPC, 0x00637B1A),
                new Location(0x78, LocationType.Free, 0x002A6162),
                new Location(0x79, LocationType.Red, 0x0021D4D0),
                new Location(0x7A, LocationType.Agent, 0x00637195),

                // Kangaroo Hoodoos
                new Location(0x7B, LocationType.Green, 0x00284126),
                new Location(0x7C, LocationType.Free, 0x0028A029),
                new Location(0x7D, LocationType.NPC, 0x0063746A),
                new Location(0x7E, LocationType.NPC, 0x00637514),
                new Location(0x7F, LocationType.NPC, 0x00637406),
                //locations.Add(new Location(0x80, LocationType.Free, ));
                new Location(0x81, LocationType.Free, 0x002A9BF2),
                new Location(0x82, LocationType.Red, 0x0028A345),

                // Moneybags Mansion
                new Location(0x83, LocationType.Free, 0x002B69B2),
                new Location(0x84, LocationType.Purple, 0x002B6BD3),
                //locations.Add(new Location(0x85, LocationType.Free, ));
                new Location(0x86, LocationType.NPC, 0x006379AF),
                new Location(0x87, LocationType.NPC, 0x006377BE),
                new Location(0x88, LocationType.Free, 0x002AA849),
                new Location(0x89, LocationType.Green, 0x002B6AFE),
                new Location(0x8A, LocationType.Agent, 0x0063714D),

                // Cheetah Spot Spa
                new Location(0x8B, LocationType.Green, 0x00250D9E),
                new Location(0x8C, LocationType.Free, 0x00250B03),
                new Location(0x8D, LocationType.NPC, 0x00636CD3),
                new Location(0x8E, LocationType.NPC, 0x00637388),
                new Location(0x8F, LocationType.NPC, 0x00636C8B),
                new Location(0x90, LocationType.NPC, 0x00636D46),
                new Location(0x91, LocationType.Agent, 0x006371DD),
                new Location(0x92, LocationType.NPC, 0x00637AC7),

                // Professors Secret Lab
                new Location(0x93, LocationType.Green, 0x0029D9C3),
                new Location(0x94, LocationType.NPC, 0x00638810),
                new Location(0x95, LocationType.Purple, 0x0029D9CB),
                new Location(0x96, LocationType.Purple, 0x00294328),
                new Location(0x97, LocationType.Yellow, 0x0029D9FA),
                new Location(0x98, LocationType.Free, 0x002ABB5E),
                new Location(0x99, LocationType.Red, 0x00294330),
                new Location(0x9A, LocationType.Red, 0x00294320),

                // Rhynocs n Clocks
                new Location(0x9B, LocationType.Purple, 0x002DEBAE),
                new Location(0x9C, LocationType.NPC, 0x0063891C),
                new Location(0x9D, LocationType.NPC, 0x00637CA3),
                new Location(0x9E, LocationType.Byrd, 0x006372B5),
                new Location(0x9F, LocationType.Yellow, 0x002DEBB5),
                new Location(0xA0, LocationType.Yellow, 0x002DEC4D),

                // Chateau Ripto
                new Location(0xA1, LocationType.Free, 0x002A70D5),
                new Location(0xA2, LocationType.Byrd, 0x0063726D),
                //locations.Add(new Location(0xA3, LocationType.Free, ));
                //locations.Add(new Location(0xA4, LocationType.Free, ));
                //locations.Add(new Location(0xA5, LocationType.Free, ));
                new Location(0xA6, LocationType.Yellow, 0x0023FD68)
            };


            return locations;
        }

        public static List<ItemSwap> NoLogic()
        {
            List<ItemSwap> itemSwaps = new List<ItemSwap>();

            List<int> from = new List<int>();
            List<int> to = new List<int>();

            List<int> excludes = new List<int> { 0x47, 0x51, 0x54, 0x6F, 0x80, 0x85, 0xA3, 0xA4, 0xA5 };

            for(int i = 0; i < 100; i++)
            {
                if (!excludes.Contains(i))
                {
                    from.Add(i + 0x43);
                    to.Add(i + 0x43);
                }
            }

            to.Shuffle();

            for (int i = 0; i < from.Count; i++)
            {
                itemSwaps.Add(new ItemSwap(from[i], to[i]));
            }
            


            return itemSwaps;
        }
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static List<ItemSwap> TestingSwaps()
        {
            List<ItemSwap> itemSwaps = new List<ItemSwap>();

            itemSwaps.Add(new ItemSwap(0x4A, 0x4B));
            itemSwaps.Add(new ItemSwap(0x4D, 0x43));


            return itemSwaps;
        }

        public static List<ItemSwap> Plando(string[] swaps)
        {
            List<ItemSwap> itemSwaps = new List<ItemSwap>();

            for (int i = 0; i < swaps.Length; i++)
            {
                string fromString = swaps[i].Split(',')[0];
                string toString = swaps[i].Split(',')[1];

                int from = int.Parse(fromString, System.Globalization.NumberStyles.HexNumber);
                int to = int.Parse(toString, System.Globalization.NumberStyles.HexNumber);

                itemSwaps.Add(new ItemSwap(from, to));
            }


            return itemSwaps;
        }
    }
}
