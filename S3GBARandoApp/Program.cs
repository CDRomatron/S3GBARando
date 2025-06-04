using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3GBARandoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("s3.gba"))
            {
                Console.WriteLine("Rom (s3.gba) missing");
                return;
            }
            byte[] bytes = File.ReadAllBytes("s3.gba");

            List<Location> locations = Data.DefaultLocations();

            if (!File.Exists("settings.csv"))
            {
                StringBuilder sb = new StringBuilder();
                foreach (var location in locations)
                {
                    sb.AppendLine(location.id.ToString("X2") + "," + location.id.ToString("X2"));
                }
                File.WriteAllText("settings.csv", sb.ToString());
            }


            int questItemAddress = 0x1C009C;

            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(bytes[questItemAddress + i].ToString("X2"));
            }*/

            List<ItemSwap> swaps = Data.Plando(File.ReadAllLines("settings.csv"));
            

            bool openAllChests = true;

            foreach (var swap in swaps)
            {
                Location location = locations.First(i => i.id == swap.itemFromID);

                bytes[location.address] = Convert.ToByte(swap.itemToID);

                switch (location.type)
                {
                    case LocationType.Free:
                        int address = questItemAddress + ((swap.itemToID - 0x43) * 8) + 2;
                        bytes[questItemAddress + ((swap.itemToID - 0x43) * 8) + 2] = 0x01;
                        break;
                    case LocationType.Red:
                        bytes[questItemAddress + ((swap.itemToID - 0x43) * 8) + 2] = 0x01;
                        break;
                    case LocationType.Green:
                        bytes[questItemAddress + ((swap.itemToID - 0x43) * 8) + 2] = 0x01;
                        break;
                    case LocationType.Purple:
                        bytes[questItemAddress + ((swap.itemToID - 0x43) * 8) + 2] = 0x01;
                        break;
                    case LocationType.Yellow:
                        bytes[questItemAddress + ((swap.itemToID - 0x43) * 8) + 2] = 0x01;
                        break;
                    case LocationType.NPC:
                        bytes[questItemAddress + ((swap.itemToID - 0x43) * 8) + 2] = 0x00;
                        break;
                    case LocationType.Byrd:
                        break;
                    case LocationType.Agent:
                        break;
                }

                Console.WriteLine("Was:" + swap.itemFromID.ToString("X2") + " Now:" + swap.itemToID.ToString("X2"));
            }

            File.WriteAllBytes("mod.gba", bytes);

            Console.Read();
        }
    }
}
