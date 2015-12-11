using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Commerce;
using NUnit.Framework;
using System.Linq;

namespace Tests.V2.Unauthenticated
{
    [TestFixture]
    public class ListingUnitTest
    {
        [Test]
        public void ShouldReturnAllListings()
        {
            var listings = GW2Api.V2().Listings.GetAll();

            //At any given moment there are at least more than 100 listings in the trading post.
            Assert.GreaterOrEqual(listings.Count(), 100);
        }

        [Test]
        public void ShouldReturnCorrectPriceById()
        {
            Listing listings = GW2Api.V2().Listings.GetById(123);

            Assert.GreaterOrEqual(listings.Buys.Count(), 1);
            Assert.GreaterOrEqual(listings.Buys.ToList()[0].Listings, 1);
            Assert.GreaterOrEqual(listings.Buys.ToList()[0].Quantity, 1);
            Assert.GreaterOrEqual(listings.Buys.ToList()[0].UnitPrice.GetRawCoin(), 1);

            Assert.GreaterOrEqual(listings.Sells.Count(), 1);
            Assert.GreaterOrEqual(listings.Sells.ToList()[0].Listings, 1);
            Assert.GreaterOrEqual(listings.Sells.ToList()[0].Quantity, 1);
            Assert.GreaterOrEqual(listings.Sells.ToList()[0].UnitPrice.GetRawCoin(), 1);

            Assert.AreEqual("Zho's Mask", listings.Item.Name);
        }

        [Test]
        public void ShouldReturnMultipleListings()
        {
            var listings = GW2Api.V2().Listings.GetMultiple(123, 125).ToList();

            Assert.AreEqual(2, listings.Count);
        }
    }
}
