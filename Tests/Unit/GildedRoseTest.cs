using Xunit;

namespace GildedRose.Tests.Unit
{
    public class GildedRoseTest
    {
        [Fact]
        public void ExampleTest()
        {
            var items = new[] 
            { 
                new Item
                {
                    Name = "Test item",
                    SellIn = 0,
                    Quality = 0
                }
            };
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();
            Assert.Equal("Test item", items[0].Name);
        }
    }
}