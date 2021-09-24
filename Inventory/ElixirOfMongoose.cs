using GildedRose;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Inventory
{
    class ElixirOfMongoose : Item
    {
        public ElixirOfMongoose()
        {
            Name = "Elixir of the Mongoose";
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
                Quality--;
            }
        }
    }
}
