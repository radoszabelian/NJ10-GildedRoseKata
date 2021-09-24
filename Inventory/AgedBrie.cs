using GildedRose;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Inventory
{
    class AgedBrie : Item
    {
        public AgedBrie()
        {
            Name = "Aged Brie";
        }

        public override void Update()
        {
            SellIn--;

            if (SellIn < 0 && Quality < 49)
            {
                Quality += 2;
            }
            else if (Quality < 50)
            {
                Quality += 1;
            }
        }
    }
}
