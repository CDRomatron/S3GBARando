using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3GBARandoApp
{
    internal class ItemSwap
    {
        public int itemFromID;
        public int itemToID;

        public ItemSwap(int itemFromID, int itemToID)
        {
            this.itemFromID = itemFromID;
            this.itemToID = itemToID;
        }
    }
}
