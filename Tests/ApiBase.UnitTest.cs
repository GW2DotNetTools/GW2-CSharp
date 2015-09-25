using GW2CSharp;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ApiBaseUnitTest
    {
        [Test]
        public void ShouldReturnCorrectJsonString() 
        {
            string actual = ApiBase.DownloadJsonString("https://api.guildwars2.com/v2/build");
            Assert.That(actual.Contains("id"));
        }

        [Test]
        public void ThrowsErrorOnNotFound()
        {
            Assert.Throws<ApiException>(() => ApiBase.DownloadJsonString("https://api.guildwars2.com/v2/buildmeh"));
        }
    }
}
