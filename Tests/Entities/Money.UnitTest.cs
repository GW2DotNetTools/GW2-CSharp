using GW2CSharp.Entities;
using NUnit.Framework;

namespace Tests.Entities
{
    [TestFixture]
    public class MoneyUnitTest
    {
        [TestCase(563412)]
        [TestCase(-563412)]
        public void CanCalculateTheCorrectRawValue(int rawValue)
        {
            Money money = new Money(rawValue);

            Assert.AreEqual(12, money.Copper);
            Assert.AreEqual(34, money.Silver);
            Assert.AreEqual(56, money.Gold);
        }

        [TestCase(563412, 563412)]
        [TestCase(563412, - 563412)]
        public void CanReturnTheCorrectRawValue(int expectedValue, int rawValue)
        {
            Money money = new Money(rawValue);

            Assert.AreEqual(expectedValue, money.GetRawCoin());
        }

        [TestCase(12, 34, 56, 12, 34, 56)]
        [TestCase(12, 34, 56, - 12, -34, -56)]
        public void CanCaculateAllValuesCorrectly(int expectedCopper, int expectedSilver, int expectedGold, int actualCopper, int actualSilver, int actualGold)
        {
            Money money = new Money(actualCopper, actualSilver, actualGold);

            Assert.AreEqual(expectedCopper, money.Copper);
            Assert.AreEqual(expectedSilver, money.Silver);
            Assert.AreEqual(expectedGold, money.Gold);
        }
    }
}
