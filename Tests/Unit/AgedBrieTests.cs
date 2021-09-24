using GildedRoseKata.Inventory;
using Xunit;

namespace GildedRose.Tests.Unit
{
    public class AgedBrieTests
    {
        [Fact]
        public void AgedBrieUpdateTest1()
        {
            var item = new AgedBrie() { Quality = 100, SellIn = 100 };

            item.Update();

            Assert.Equal(99, item.SellIn);
            Assert.Equal(100, item.Quality);
        }

        [Fact]
        public void AgedBrieUpdateTest2()
        {
            var item = new AgedBrie() { Quality = 30, SellIn = -10 };

            item.Update();

            Assert.Equal(-11, item.SellIn);
            Assert.Equal(32, item.Quality);
        }

        [Fact]
        public void AgedBrieUpdateTest3()
        {
            var item = new AgedBrie() { Quality = 77, SellIn = -10 };

            item.Update();

            Assert.Equal(-11, item.SellIn);
            Assert.Equal(77, item.Quality);
        }

        [Fact]
        public void AgedBrieUpdateTest4()
        {
            var item = new AgedBrie() { Quality = 49, SellIn = -10 };

            item.Update();

            Assert.Equal(-11, item.SellIn);
            Assert.Equal(50, item.Quality);
        }
    }
}