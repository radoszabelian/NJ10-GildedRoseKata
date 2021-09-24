using GildedRose;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    class GildedRose
    {
        private IEnumerable<Item> Inventory = new List<Item>();
        private int dayNumber = 0;

        public GildedRose(IEnumerable<Item> _Inventory)
        {
            Inventory = _Inventory;
        }

        public string GetCurrentDay()
        {
            StringBuilder report = new StringBuilder();

            report.AppendLine($"-------- day {dayNumber} --------");
            report.AppendLine("name, sellIn, quality");

            foreach (var item in Inventory)
            {
                report.AppendLine($"{item.Name}, {item.SellIn}, {item.Quality}");
            }

            return report.ToString();
        }

        public void CalculateNextDay()
        {
            foreach (var item in Inventory)
            {
                item.Update();
            }

            dayNumber++;
        }

    }
}
