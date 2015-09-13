using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Currencies;
using GW2CSharp.V2.Unauthenticated.Miscellaneous.Currencies.Enums;
using NUnit.Framework;

namespace Tests.V2.Unauthenticated.Miscellaneous.Currencies
{
    [TestFixture]
    public class CurrencyUnitTest
    {
        [Test]
        public void ReturnsCorrectCurrency() 
        {
            Currency expectedCurrency = new Currency(4, "Gem", "Purchased and spent via the Black Lion Trading Company.", 0, "https://render.guildwars2.com/file/220061640ECA41C0577758030357221B4ECCE62C/502065.png");
            
            Currency actualCurrency = GW2Api.Currencies.GetCurrency(CurrencyArt.Gem);

            Assert.AreEqual(expectedCurrency.Id, actualCurrency.Id);
            Assert.AreEqual(expectedCurrency.Name, actualCurrency.Name);
            Assert.AreEqual(expectedCurrency.Description, actualCurrency.Description);
            Assert.AreEqual(expectedCurrency.Order, actualCurrency.Order);
            Assert.AreEqual(expectedCurrency.Icon, actualCurrency.Icon);
        }
    }
}
