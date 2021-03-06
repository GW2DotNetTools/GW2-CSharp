﻿using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Currencies;
using GW2CSharp.V2.Unauthenticated.Currencies.Enums;
using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Tests.V2.Unauthenticated
{
    [TestFixture]
    public class CurrencyUnitTest
    {
        [Test]
        public void ShouldReturnCorrectCurrency() 
        {
            Currency expectedCurrency = new Currency(4, "Gem", "Purchased and spent via the Black Lion Trading Company.", 100, "https://render.guildwars2.com/file/220061640ECA41C0577758030357221B4ECCE62C/502065.png");

            Currency actualCurrency = GW2Api.V2().Currencies.Get(CurrencyType.Gem);

            Assert.AreEqual(expectedCurrency.Id, actualCurrency.Id);
            Assert.AreEqual(expectedCurrency.Name, actualCurrency.Name);
            Assert.AreEqual(expectedCurrency.Description, actualCurrency.Description);
            Assert.AreEqual(expectedCurrency.Order, actualCurrency.Order);
            Assert.AreEqual(expectedCurrency.Icon, actualCurrency.Icon);
        }

        [Test]
        public void ShouldReturnAllCurrencies()
        {
            IEnumerable<Currency> currencies = GW2Api.V2().Currencies.GetAll();
            Assert.GreaterOrEqual(currencies.Count(), 21);
        }

        [Test]
        public void ShouldReturnCorrectBitmap()
        {
            Bitmap gem = GW2Api.V2().Currencies.Get(CurrencyType.Gem).GetImage();
            Assert.NotNull(gem);
        }
    }
}
