using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        private IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            const string BACKSTAGE = "Backstage passes to a TAFKAL80ETC concert";
            const string SULFURAS = "Sulfuras, Hand of Ragnaros";
            const string BRIE = "Aged Brie";

            for (var i = 0; i < Items.Count; i++)
            {
                var actualItem = Items[i];


                if (actualItem.Name != BRIE && actualItem.Name != BACKSTAGE && actualItem.Name != SULFURAS && actualItem.Quality > 0)
                {
                    actualItem.Quality--;
                }
                else if (actualItem.Quality < 50)
                {
                    actualItem.Quality++;

                    if (actualItem.Name == BACKSTAGE && actualItem.Quality < 50)
                    {
                        if (actualItem.SellIn < 6)
                        {
                            actualItem.Quality += 2;
                        }
                        else if (actualItem.SellIn < 11)
                        {
                            actualItem.Quality++;
                        }
                    }
                }

                if (actualItem.Name != SULFURAS)
                {
                    actualItem.SellIn--;
                }

                if (actualItem.SellIn < 0)
                {
                    if (actualItem.Name != BRIE)
                    {
                        if (actualItem.Name != BACKSTAGE)
                        {
                            if (actualItem.Quality > 0)
                            {
                                if (actualItem.Name != SULFURAS)
                                {
                                    actualItem.Quality--;
                                }
                            }
                        }
                        else
                        {
                            actualItem.Quality = 0;
                        }
                    }
                    else
                    {
                        if (actualItem.Quality < 50)
                        {
                            actualItem.Quality++;
                        }
                    }
                }
            }
        }
    }
}