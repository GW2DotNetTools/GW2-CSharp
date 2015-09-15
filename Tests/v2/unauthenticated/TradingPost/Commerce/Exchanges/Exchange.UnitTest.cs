using GW2CSharp;
using GW2CSharp.Entities;
using GW2CSharp.V2.Unauthenticated.TradingPost.Commerce.Exchanges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.V2.Unauthenticated.TradingPost.Commerce.Exchanges
{
    [TestFixture]
    public class ExchangeUnitTest
    {
        [Test]
        public void ShouldReturnCorrectCoin() 
        {
            Coin coin = GW2Api.V2.Exchanges.GetCoin(new Money(10000));
            Assert.Greater(coin.AmountOfGems, 0);
            Assert.Greater(coin.CoinsPerGemRaw, 0);
            Assert.NotNull(coin.CoinsPerGemCalculated);
        }

        [Test]
        public void ShouldReturnCorrectGem()
        {
            Gem gem = GW2Api.V2.Exchanges.GetGem(100);

            Assert.NotNull(gem.AmountOfCoinsCalculated);
            Assert.NotNull(gem.CoinsPerGemCalculated);
            Assert.Greater(gem.AmountOfCoinsRaw, 0);
            Assert.Greater(gem.CoinsPerGemRaw, 0);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void ThrowsExceptionOnWrongGemValues(int value)
        {
            Assert.Throws<ArgumentException>(() => GW2Api.V2.Exchanges.GetGem(value));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void ThrowsExceptionOnWrongCoinValues(int value)
        {
            Assert.Throws<ArgumentException>(() => GW2Api.V2.Exchanges.GetCoin(new Money(value)));
        }
    }
}
