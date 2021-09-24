using GildedRose;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Inventory
{
    class DexterityVest : Item
    {
        public DexterityVest()
        {
            Name = "+5 Dexterity Vest";
        }

        public override void Update()
        {
            if (Quality > 0)
            {
                Quality -= 1;
            }

            SellIn--;

            if (SellIn < 0 && Quality > 0)
            {
                Quality -= 1;
            }
        }
    }
}
