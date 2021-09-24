using GildedRose;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Inventory
{
    class Sulfuras : Item
    {
        public Sulfuras()
        {
            Name = "Sulfuras, Hand of Ragnaros";
        }

        public override void Update()
        {
            if (Quality < 50)
            {
                Quality++;
            }
        }
    }
}
