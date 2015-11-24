using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Commerce;
using NUnit.Framework;
using System.Linq;

namespace Tests.V2.Unauthenticated
{
    [TestFixture]
    public class PriceUnitTest
    {
        [Test]
        public void ShouldReturnAllPrices()
        {
            var prices = GW2Api.V2.Prices.GetAll();

            //At any given moment there are at least more than 100 listings in the trading post.
            Assert.GreaterOrEqual(prices.Count, 100);
        }

        [Test]
        public void ShouldReturnCorrectPriceById()
        {
            Price price = GW2Api.V2.Prices.GetById(123);

            Assert.GreaterOrEqual(price.Buys.Quantity, 1);
            Assert.GreaterOrEqual(price.Buys.UnitPrice.GetRawCoin(), 1);

            Assert.GreaterOrEqual(price.Sells.Quantity, 1);
            Assert.GreaterOrEqual(price.Sells.UnitPrice.GetRawCoin(), 1);

            Assert.AreEqual("Zho's Mask" , price.Item.Name);
        }

        [Test]
        public void ShouldReturnMultiplePrices()
        {
            var prices = GW2Api.V2.Prices.GetMultiple(123, 125).ToList();

            Assert.AreEqual(2, prices.Count);
        }
    }
}
