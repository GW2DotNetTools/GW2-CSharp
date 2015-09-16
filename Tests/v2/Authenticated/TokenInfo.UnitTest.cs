using GW2CSharp;
using GW2CSharp.V2.Authenticated.TokenInfo;
using NUnit.Framework;

namespace Tests.V2.Authenticated
{
    [TestFixture]
    public class TokeninfoUnitTest
    {
        private const string TestAccountToken = "58751B23-07DA-AB49-A5DE-0DBC9BA6C79ECCDE107E-2785-4296-BAEF-64AD20580F8A";
        private const string TestAccountTokenName = "Muh Pantsu";

        [Test]
        public void ShouldHaveAllPermissions() 
        {
            Tokeninfo tokeninfo = GW2Api.V2.TokenInfo.GetTokeninfo(TestAccountToken);
            
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
            Tokeninfo tokeninfo = GW2Api.V2.TokenInfo.GetTokeninfo(TestAccountToken);

            Assert.AreEqual(TestAccountTokenName, tokeninfo.Name);
        }

        [Test]
        public void ShouldHaveCorrectTokenId()
        {
            Tokeninfo tokeninfo = GW2Api.V2.TokenInfo.GetTokeninfo(TestAccountToken);

            Assert.AreEqual(TestAccountToken.Substring(0, 36), tokeninfo.Id); // Seems like only 36 letters of the Id will be returned.
        }
    }
}
