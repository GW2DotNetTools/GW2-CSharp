using GW2CSharp;
using GW2CSharp.Entities;
using GW2CSharp.V2.Unauthenticated.Commerce.Exchange;
using NUnit.Framework;

namespace Tests.V2.Unauthenticated
{
    [TestFixture]
    public class ExchangeUnitTest
    {
        [Test]
        public void ShouldReturnCorrectCoin() 
        {
            Coin coin = GW2Api.V2().Exchanges.GetCoin(new Money(10000));
            Assert.Greater(coin.AmountOfGems, 0);
            Assert.Greater(coin.CoinsPerGemRaw, 0);
            Assert.NotNull(coin.CoinsPerGemCalculated);
        }

        [Test]
        public void ShouldReturnCorrectGem()
        {
            Gem gem = GW2Api.V2().Exchanges.GetGem(8000);

            Assert.NotNull(gem.AmountOfCoinsCalculated);
            Assert.NotNull(gem.CoinsPerGemCalculated);
            Assert.Greater(gem.AmountOfCoinsRaw, 0);
            Assert.Greater(gem.CoinsPerGemRaw, 0);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void ThrowsExceptionOnWrongGemValues(int value)
        {
            Assert.Throws<ApiException>(() => GW2Api.V2().Exchanges.GetGem(value));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void ThrowsExceptionOnWrongCoinValues(int value)
        {
            Assert.Throws<ApiException>(() => GW2Api.V2().Exchanges.GetCoin(new Money(value)));
        }
    }
}
