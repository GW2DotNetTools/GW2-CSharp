using GW2CSharp;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class ApiBaseUnitTest
    {
        [Test]
        public void ReturnsCorrectJsonString() 
        {
            string actual = ApiBase.DownloadJsonString("https://api.guildwars2.com/v2/build");
            Assert.That(actual.Contains("id"));
        }

        [Test]
        public void ThrowsErrorOnNotFound()
        {
            Assert.Throws<ArgumentException>(() => ApiBase.DownloadJsonString("https://api.guildwars2.com/v2/buildmeh"));
        }
    }
}
