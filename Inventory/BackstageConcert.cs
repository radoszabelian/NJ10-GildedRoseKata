using GildedRose;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Inventory
{
    class BackstageConcert : Item
    {
        public BackstageConcert()
        {
            Name = "Backstage passes to a TAFKAL80ETC concert";
        }

        public override void Update()
        {
            if (Quality < 49 && SellIn < 6) Quality += 3;
            else if (Quality < 49 && SellIn < 11) Quality += 2;
            else if (Quality < 49 && SellIn > 11) Quality += 1;
            else if (Quality < 50) Quality += 1;

            SellIn--;

            if (SellIn < 0) Quality = 0;
        }
    }
}
