using GW2CSharp;
using GW2CSharp.V2.Authenticated.TokenInfo;
using NUnit.Framework;

namespace Tests.V2.Authenticated
{
    [TestFixture]
    public class TokeninfoUnitTest
    {

        [Test]
        public void ShouldHaveAllPermissions() 
        {
            Tokeninfo tokeninfo = GW2Api.V2().TokenInfo.Get(TestData.FullAccessAccountToken);
            
            Assert.IsTrue(tokeninfo.Permission.Account);
            Assert.IsTrue(tokeninfo.Permission.Builds);
            Assert.IsTrue(tokeninfo.Permission.Characters);
            Assert.IsTrue(tokeninfo.Permission.Inventories);
            Assert.IsTrue(tokeninfo.Permission.Pvp);
            Assert.IsTrue(tokeninfo.Permission.Tradingpost);
            Assert.IsTrue(tokeninfo.Permission.Unlocks);
            Assert.IsTrue(tokeninfo.Permission.Wallet);
        }

        [Test]
        public void ShouldHaveCorrectTokenName()
        {
            Tokeninfo tokeninfo = GW2Api.V2().TokenInfo.Get(TestData.FullAccessAccountToken);

            Assert.AreEqual(TestData.FullAccessAccountTokenName, tokeninfo.Name);
        }

        [Test]
        public void ShouldHaveCorrectTokenId()
        {
            Tokeninfo tokeninfo = GW2Api.V2().TokenInfo.Get(TestData.FullAccessAccountToken);

            Assert.AreEqual(TestData.FullAccessAccountToken.Substring(0, 36), tokeninfo.Id); // Seems like only 36 letters of the Id will be returned.
        }
    }
}
