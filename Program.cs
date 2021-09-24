using GildedRose;
using GildedRoseKata.Inventory;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main()
        {
            IList<Item> Items = new List<Item>
            {
                new DexterityVest {SellIn = 10, Quality = 20},
                new AgedBrie {SellIn = 2, Quality = 0},
                new ElixirOfMongoose {SellIn = 5, Quality = 7},
                new Sulfuras {SellIn = 0, Quality = 80},
                new Sulfuras {SellIn = -1, Quality = 80},
                new BackstageConcert {SellIn = 15, Quality = 20 },
                new BackstageConcert {SellIn = 10, Quality = 49 },
                new BackstageConcert {SellIn = 5, Quality = 49 },
                new ConjuredManaCake { SellIn = 3, Quality = 6}
            };

            GildedRose app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                System.Console.WriteLine(app.GetCurrentDay());

                app.CalculateNextDay();
            }
        }
    }
}