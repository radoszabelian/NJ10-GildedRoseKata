using GildedRose;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Inventory
{
    class ConjuredManaCake : Item
    {
        public ConjuredManaCake()
        {
            Name = "Conjured Mana Cake";
        }

        public override void Update()
        {
            if (Quality > 0)
            {
                Quality--;
            }

            SellIn--;

            if (SellIn < 0 && Quality > 0)
            {
                Quality--;
            }
        }
    }
}
