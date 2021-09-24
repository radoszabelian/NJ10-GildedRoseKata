using GildedRoseKata.Inventory;
using Xunit;

namespace GildedRoseKata.Tests.Unit
{
    public class BackstageConcertTests
    {
        [Fact]
        public void BackstageConcertTest1()
        {
            var item = new BackstageConcert() { Quality = 100, SellIn = 100 };

            item.Update();

            Assert.Equal(99, item.SellIn);
            Assert.Equal(100, item.Quality);
        }

        [Fact]
        public void BackstageConcertTest2()
        {
            var item = new BackstageConcert() { Quality = 48, SellIn = 5 };

            item.Update();

            Assert.Equal(4, item.SellIn);
            Assert.Equal(51, item.Quality);
        }

        [Fact]
        public void BackstageConcertTest3()
        {
            var item = new BackstageConcert() { Quality = 48, SellIn = 8 };

            item.Update();

            Assert.Equal(7, item.SellIn);
            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void BackstageConcertTest4()
        {
            var item = new BackstageConcert() { Quality = 48, SellIn = 20 };

            item.Update();

            Assert.Equal(19, item.SellIn);
            Assert.Equal(49, item.Quality);
        }

        [Fact]
        public void BackstageConcertTest5()
        {
            var item = new BackstageConcert() { Quality = 17, SellIn = 11 };

            item.Update();

            Assert.Equal(10, item.SellIn);
            Assert.Equal(18, item.Quality);
        }

        [Fact]
        public void BackstageConcertTest6()
        {
            var item = new BackstageConcert() { Quality = 66, SellIn = 0 };
            
            item.Update();

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(0, item.Quality);
        }
    }
}
